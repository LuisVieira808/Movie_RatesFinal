using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using MovieRates.Data;
using MovieRates.Models;

namespace MovieRates.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        //private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        //private readonly IEmailSender _emailSender;
        
        /// <summary>
        /// referência à BD do nosso sistema
        /// </summary>
        private readonly ApplicationDbContext _context;

        public RegisterModel(
            UserManager<IdentityUser> userManager,
           // SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            //IEmailSender emailSender,
            ApplicationDbContext context)
        {
            _userManager = userManager;
            //_signInManager = signInManager;
            _logger = logger;
            //_emailSender = emailSender;
            _context = context;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        //public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            public Utilizadores Utilizador { get; set; }
        }

        /// <summary>
        /// Metodo a ser executado pela pagina, quando o HTTP é invocado em GET
        /// </summary>
        /// <param name="returnUrl"></param>
        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            //ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            //ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = new IdentityUser {
                    UserName = Input.Email,
                    Email = Input.Email,
                    //EmailConfirmed = true,
                    //EmailConfirmed = false // o email não está formalmente confirmado
                    //LockoutEnabled = true,  // o utilizador pode ser bloqueado
                    LockoutEnd = new DateTime(DateTime.Now.Year + 10,
                                          DateTime.Now.Month,
                                          DateTime.Now.Day)
                    //DataRegisto = DateTime.Now // data do registo
                };
                var result = await _userManager.CreateAsync(user, Input.Password);
                
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");
                   
                    //await _userManager.AddToRoleAsync(user, "Utilizador");



                    //*************************************************************
                    // Vamos proceder à operação de guardar os dados do Criador
                    //*************************************************************
                    // preparar os dados do Criador para serem adicionados à BD
                     // atribuir ao objeto 'criador' o email fornecido pelo utilizador,
                                                       // a quando da escreita dos dados na interface
                                                       // exatamente a mesma tarefa feita na linha 128

                      // adicionar o ID do utilizador,
                                                       // para formar uma 'ponte' (foreign key) entre
                                                       // os dados da autenticação e os dados do 'negócio'


                    // estamos em condições de guardar os dados na BD
                    
                    Input.Utilizador.Email = Input.Email;
                        Input.Utilizador.UserNameId = user.Id;
                    
                    try {
                        //_context.Add(Input.Utilizador); // adicionar o Criador
                        //await _context.SaveChangesAsync(); // 'commit' da adição
                                                           // Enviar para o utilizador para a página de confirmação da criaçao de Registo
                        //return RedirectToPage("RegisterConfirmation");
                        await _userManager.AddToRoleAsync(user, "Utilizador");
                        
                        await _context.AddAsync(Input.Utilizador);
                        await _context.SaveChangesAsync(); // 'commit' da adição
                                                           // Enviar para o utilizador para a página de confirmação da criaçao de Registo
                        return RedirectToPage("RegisterConfirmation");
                    } catch (Exception) {
                        // avisar que houve um erro
                        
                        ModelState.AddModelError("", "Ocorreu um erro na criação de dados");
                        // deverá ser apagada o User q foi previamente criador
                        await _userManager.DeleteAsync(user);
                        
                        // devolver dados à pagina
                        return Page();
                    }




                    /*var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }*/
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
