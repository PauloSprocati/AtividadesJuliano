using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ProgramacaoIV.Exercicios.Janelas
{
    public enum EnumTipoUsuario
    {
        [Description("Administrador do sistema")]
        Administrador,

        [Description("Usuário com permissões comuns")]
        UsuarioComum,

        [Description("Visitante com acesso restrito")]
        Visitante
    }
}
