(s){var c3=[];function ca3(n){if(n==0) return 1;return c3[n]?c3[n]:c3[n]=(4*n-2)*ca3(n-1)/(n+1);}console.log(ca3(s)/2)}
