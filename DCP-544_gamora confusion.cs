#define ONLINE_JUDGE 1
#include<bits/stdc++.h>
using namespace std;


int main()
{
    int n;
    scanf("%d", &n);

    for(int i=0; i<n; i++){
        char arr[50];
        cin>>arr;

        if(strcmp(arr, "Quill")==0){
            cout<<"I am going to ask you this one time, where is Gamora?"<<endl;
        }
        else if (strcmp(arr, "Stark")==0){
            cout<<"I will do you one better, who is Gamora?"<<endl;
        }
        else if(strcmp(arr, "Drax")==0){
            cout<<"I will do you one better, why is Gamora?"<<endl;
        }
        else{
            cout<<"What is Gamora?"<<endl;
        }
    }
}
