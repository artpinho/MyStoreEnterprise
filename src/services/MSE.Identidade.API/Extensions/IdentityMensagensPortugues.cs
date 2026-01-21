using Microsoft.AspNetCore.Identity;

namespace MSE.Identidade.API.Extensions
{
    public class IdentityMensagensPortugues : IdentityErrorDescriber
    {
        public override IdentityError DefaultError()
        {
            return new IdentityError
            {
                Code = "IdentityDefaultError",
                Description = "Ocorreu um erro desconhecido."
            };
        }

        public override IdentityError ConcurrencyFailure()
        {
            return new IdentityError
            {
                Code = "IdentityConcurrencyFailure",
                Description = "Falha de concorrência otimista, o objeto foi modificado."
            };
        }
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError
            {
                Code = "IdentityPasswordTooShort",
                Description = $"A senha deve ter no mínimo {length} caracteres."
            };
        }

        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError
            {
                Code = "IdentityPasswordRequiresNonAlphanumeric",
                Description = "A senha deve conter pelo menos um caractere não alfanumérico."
            };
        }

        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError
            {
                Code = "IdentityPasswordRequiresDigit",
                Description = "A senha deve conter pelo menos um dígito ('0'-'9')."
            };
        }

        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError
            {
                Code = "IdentityPasswordRequiresLower",
                Description = "A senha deve conter pelo menos uma letra minúscula ('a'-'z')."
            };
        }

        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError
            {
                Code = "IdentityPasswordRequiresUpper",
                Description = "A senha deve conter pelo menos uma letra maiúscula ('A'-'Z')."
            };
        }

        public override IdentityError PasswordRequiresUniqueChars(int uniqueChars)
        {
            return new IdentityError
            {
                Code = "IdentityPasswordRequiresUniqueChars",
                Description = $"A senha deve conter pelo menos {uniqueChars} caracteres únicos."
            };
        }

        public override IdentityError InvalidUserName(string userName)
        {
            return new IdentityError
            {
                Code = "IdentityInvalidUserName",
                Description = $"O nome de usuário '{userName}' é inválido, pode conter apenas letras ou dígitos."
            };
        }

        public override IdentityError DuplicateUserName(string userName)
        {
            return new IdentityError
            {
                Code = "IdentityDuplicateUserName",
                Description = $"O nome de usuário '{userName}' já está sendo utilizado."
            };
        }

        public override IdentityError DuplicateEmail(string email)
        {
            return new IdentityError
            {
                Code = "IdentityDuplicateEmail",
                Description = $"O e-mail '{email}' já está sendo utilizado."
            };
        }

        public override IdentityError InvalidEmail(string email)
        {
            return new IdentityError
            {
                Code = "IdentityInvalidEmail",
                Description = $"O e-mail '{email}' é inválido."
            };
        }

        public override IdentityError UserAlreadyHasPassword()
        {
            return new IdentityError
            {
                Code = "IdentityUserAlreadyHasPassword",
                Description = "O usuário já possui uma senha definida."
            };
        }

        public override IdentityError UserLockoutNotEnabled()
        {
            return new IdentityError
            {
                Code = "IdentityUserLockoutNotEnabled",
                Description = "O bloqueio de usuário não está habilitado para este usuário."
            };
        }

        public override IdentityError UserNotInRole(string role)
        {
            return new IdentityError
            {
                Code = "IdentityUserNotInRole",
                Description = $"O usuário não pertence ao papel '{role}'."
            };
        }

        public override IdentityError PasswordMismatch()
        {
            return new IdentityError
            {
                Code = "IdentityPasswordMismatch",
                Description = "Senha incorreta."
            };
        }

        public override IdentityError LoginAlreadyAssociated()
        {
            return new IdentityError
            {
                Code = "IdentityLoginAlreadyAssociated",
                Description = "Já existe um usuário com este login."
            };
        }

        public override IdentityError InvalidToken()
        {
            return new IdentityError
            {
                Code = "IdentityInvalidToken",
                Description = "O token fornecido é inválido."
            };
        }

        public override IdentityError RecoveryCodeRedemptionFailed()
        {
            return new IdentityError
            {
                Code = "IdentityRecoveryCodeRedemptionFailed",
                Description = "Falha ao resgatar o código de recuperação."
            };
        }

        public override IdentityError UserAlreadyInRole(string role)
        {
            return new IdentityError
            {
                Code = "IdentityUserAlreadyInRole",
                Description = $"O usuário já pertence ao papel '{role}'."
            };
        }

        public override IdentityError InvalidRoleName(string role)
        {
            return new IdentityError
            {
                Code = "IdentityInvalidRoleName",
                Description = $"O nome do papel '{role}' é inválido."
            };
        }

        public override IdentityError DuplicateRoleName(string role)
        {
            return new IdentityError
            {
                Code = "IdentityDuplicateRoleName",
                Description = $"O nome do papel '{role}' já está sendo utilizado."
            };
        }      

    }
}

