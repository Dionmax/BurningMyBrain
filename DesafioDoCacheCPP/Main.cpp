#include <iostream>
#include <map>

using namespace std;

template <typename T>
class Cache {
    
    private:
        int tamanhoMaximo = 0;
        map<int, T>* obj;
       // int objOrder = 0;
       
    public:
    
    Cache(){}
    
    Cache(int tamanhoMaximo){
        this->tamanhoMaximo = tamanhoMaximo;
        obj = new map[tamanhoMaximo];
    }
    
    int getTamanhoMaximo(){
        return tamanhoMaximo;
    }
    
    void add(T value) {
        //map[objOrder] = value;
        //objOrder ++;
        
        obj.insert ();
    }
    
    T get(T value) {
       for(map<int, T>::iterator it = obj.begin(); it != obj.end(); ++it){
           if(it->second == value)
           return it->second;
       }
    }
    
};

int main()
{
    Cache<int> a(2);
   
    cout << a.getTamanhoMaximo();

    return 0;
}