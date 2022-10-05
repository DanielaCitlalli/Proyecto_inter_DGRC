export interface CirrTa01Napeticion {
    ta01EOid: number| null;
    ta01ESecuencia?: number| null;
    ta01EPrioridad?: number| null;
    ta01EOperacionacto: number;
    ta01CCadena: string;
    ta01FEntrada?: Date| null;
    ta01EEstatus?: number| null;
    ta07EEstadodest?: number| null;
    ta07EOiddestino?: number| null;
    ta07ESolicitarimagen?: number| null;
    ta01FAtencion?: Date| null;
    ta01ECuantos?: number| null;
}
