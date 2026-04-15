#include <iostream>
#include <vector>
#include <string>

using namespace std;

int main() {
    int n;
    cin>>n;
    vector<string> str;
    vector<int> count;

    for(int i=0;i<26;i++) {
        count.push_back(0);
    }
    for(int i=0;i<n;i++) {
        string a;
        cin>>a;
        str.push_back(a);
    }
    for(string i : str) {
        count[(i[0] - 'a')] += 1;
    }
    int d = 1;
    for(int i=0;i<26;i++) {
        if(count[i] >= 5) {
            printf("%c",'a'+i);
            d = 0;
        }
    }
    if(d) {
        cout<<"PREDAJA";
    }
}