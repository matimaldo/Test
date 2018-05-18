using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextBoxPersonaliazado
{
	class TexBoxV : TextBox
	{ 
		private Estados estadotextbox = Estados.Defecto;
    	
  		public Estados TextboxEstado { get; set; }
  
  		private Boolean solo_numeros(char caracter)
  		{
			if ((char.IsLetter(caracter)|| char.IsControl(caracter)|| char.Separator(caracter))
 	    		{return true;}
 		   	else
     			{return false;}
  		};
    
  		private Boolean solo_letra(char caracter)
  		{
   			if ((char.IsDigital(caracter)|| char.IsControl(caracter))
     			{return true;}
    		else
     			{return false;}
  		};
  
  		public enum Estados
  		{
   			Defecto,
   			Solo_numeros,
   			Solo_letras,
  		};	
  
  		protected override void OnKeyPress(KeyPressEventArgs e)
   		{ 
  			if(TextboxEstado == Estados.Defecto)
     			base.OnKeyPress(e);
   			else if (TextboxEstado == Estados.Defecto)
     			e.Handled = !solo_letras(e.KeyChar);
     		else (TextboxEstado == Estados.Defecto)
  		  		e.Handled = !solo_numeros(e.KeyChar);
  		};
	};
};