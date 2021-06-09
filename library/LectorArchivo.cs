
namespace library
{
    public class LectorArchivo : ILectorArchivo
    {
        public string LeerArchivo(string rutaArchivo)
        {

            System.IO.StreamReader streamReader = new System.IO.StreamReader(rutaArchivo);

            string infoFile = streamReader.ReadToEnd();

            streamReader.Close();

            return infoFile;
        }
        
    }

    public interface ILectorArchivo
    {
         string LeerArchivo(string rutaArchivo);
    }
}