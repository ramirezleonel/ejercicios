public int buscar(int[] valores, int inicio,int fin ,int a){
	int pos;
	pos = inicio+fin/2;
    if(inicio> fin ) 
    	return -1;
    
    else if(pos ==a){
    		return pos;
    }
    else  if(valores[pos]>a )
    		return buscar(valores,inicio,pos-1,a );

    else return buscar(valores,pos+1,fin,a  );
    	
    
    
    
	}
}
