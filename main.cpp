#include <bits/stdc++.h>
#include <Windows.h>
#include <locale>

using namespace std;

int _N;
vector<int> dat;
vector<vector<char>> cmpdat;

bool cmp(int a, int b);

int main(void)
{
    setlocale(LC_ALL, "");

    wprintf(L"후보 수 : ");
    scanf("%d", &_N);
    cmpdat.assign(_N, vector<char>(_N, 0));
    for (int i = 1; i <= _N; i++) dat.push_back(i);
    sort(dat.begin(), dat.end(), cmp);
    printf("------------------\n");
    for (int i = 0; i < _N; i++) wprintf(L"%d위 : %d번\n", i + 1, dat[i]);
    system("pause>nul");
    return 0;
}

bool cmp(int a, int b)
{
    if (cmpdat[a - 1][b - 1]) return cmpdat[a - 1][b - 1] == 1;
    int c;
    while (true)
    {
        printf("%d vs %d --> ", a, b);
        scanf("%d", &c);
        if (c == a || c == b) break;
        wprintf(L"뒤질래? 다시해\n");
    }
    cmpdat[a - 1][b - 1] = c == a ? 1 : -1;
    cmpdat[b - 1][a - 1] = -cmpdat[a - 1][b - 1];

    for (int k = 0; k < _N; k++)
    {
        for (int i = 0; i < _N; i++)
        {
            if (k == i) continue;
            for (int j = 0; j < _N; j++)
            {
                if (k == j || i == j) continue;
                if (cmpdat[i][k] * cmpdat[k][j] == 1)
                {
                    cmpdat[i][j] = cmpdat[i][k];
                    cmpdat[j][i] = -cmpdat[i][j];
                }
            }
        }
    }

    return cmpdat[a - 1][b - 1] == 1;
}