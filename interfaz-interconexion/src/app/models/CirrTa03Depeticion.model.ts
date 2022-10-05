export interface CirrTa03Depeticion{
    ta03EOid: number;
    ta03EPrioridad?: number | null;    
    ta03EOperacionacto:  number ;  
    ta03CCadena: string ;  
    ta03EEstatus?:  number | null;  
    ta03FEntrada?: Date | null;  
    ta07EEstadodest?:  number | null;  
    ta07EOiddestino?:  number | null;  
    ta07ESolicitarimagen?:  number | null;  
    ta03ESecuencia?:  number | null;  
    ta03FAtencion?: Date | null;  
    ta03ECuantos: number;  
}

