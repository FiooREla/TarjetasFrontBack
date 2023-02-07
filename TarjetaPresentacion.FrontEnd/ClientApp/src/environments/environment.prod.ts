import { Environment } from "./enviroment-model";


export const environment : Environment = {
  production: true,
  urlAddress: 'http://172.18.12.10:9090',
};

//#region url WS Busqueda Empresa
export const environmentBP :Environment =  {
  production: true,
  urlAddress: 'https://dniruc.apisperu.com',
};

