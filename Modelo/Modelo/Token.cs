using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Token
    {
        public long id_token;
        public Usuario usuario;
        public String token;
        public DateTime date_time;

        public Token()
        {

        }
        public Token(long id_token,Usuario u, String token, DateTime date_time)
        {

            this.id_token = id_token;
            this.usuario = u;
            this.token = token;
            this.date_time = date_time;
        }


        public Token(Usuario usuario, String token, DateTime date_time)
        {
            this.usuario = usuario;
            this.token = token;
            this.date_time = date_time;
        }
              

        public long getId_token()
        {
            return id_token;
        }

        public void setId_token(long id_token)
        {
            this.id_token = id_token;
        }

        public Usuario getUsuario()
        {
            return usuario;
        }

        public void setUsuario(Usuario usuario)
        {
            this.usuario = usuario;
        }

        public String getToken()
        {
            return token;
        }

        public void setToken(String token)
        {
            this.token = token;
        }

        public DateTime getDate_time()
        {
            return date_time;
        }

        public void setDate_time(DateTime date_time)
        {
            this.date_time = date_time;
        }

        
        public String toString()
        {
            return "Token{" + "id_token=" +id_token + ", usuario=" + usuario.toString() + ", token=" + token + ", date_time=" + date_time + '}';
        }


    }
}
