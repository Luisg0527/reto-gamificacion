
namespace AvanceWeb.Model
{
    public class MetricasDash{
        
        public int idmetricas {get; set;}
        public float ingresos { get; set; }
        public float ganancias { get; set; } 
        public int ordenes { get; set; } 
        public int visistas { get; set; } 
        

        public MetricasDash(int idmetricas_, float ingresos_, float ganancias_, int ordenes_, int visitas_){
            this.idmetricas = idmetricas_;
            this.ingresos = ingresos_;
            this.ganancias = ganancias_;
            this.ordenes = ordenes_;
            this.visistas = visitas_;
        }
    }
    
}