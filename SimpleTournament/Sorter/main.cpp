#include <bits/stdc++.h>
#include <Windows.h>

using namespace std;

struct Pair
{
    unsigned char type;
    int length;
    unsigned char value[1024];
};

HANDLE hnd;
struct Pair* p;

int _N;
vector<int> dat;
vector<vector<char>> cmpdat;

bool cmp(int a, int b);

int main(void)
{
    hnd = CreateFileMappingW(INVALID_HANDLE_VALUE, NULL, PAGE_READWRITE, 0, sizeof(Pair), L"SorterSmem");
    p = (struct Pair*) MapViewOfFile(hnd, FILE_MAP_READ | FILE_MAP_WRITE, 0, 0, sizeof(Pair));

    while (p->type == 0);
    _N = p->length;
    cmpdat.assign(_N, vector<char>(_N, 0));

    srand(time(NULL));
    for (int i = 0; i < _N; i++) dat.push_back(i);
    random_shuffle(dat.begin(), dat.end());
    sort(dat.begin(), dat.end(), cmp);

    while (p->type == 1);
    char buf[1024] = "e";
    for (int i = 0; i < _N; i++) sprintf(buf, " %d", dat[i]);
    memcpy(p->value, buf, sizeof(buf));
    p->length = strlen(buf);
    p->type = 1;

    return 0;
}

bool cmp(int a, int b)
{
    if (cmpdat[a][b]) return cmpdat[a][b] == 1;
    int c;

    char buf[1024];
	sprintf(buf, "%d %d", a, b);
    memcpy(p->value, buf, sizeof(buf));
    p->length = strlen(buf);
    p->type = 1;

    while (p->type == 1);
    c = p->length;

    cmpdat[a][b] = c == a ? 1 : -1;
    cmpdat[b][a] = -cmpdat[a][b];

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

    return cmpdat[a][b] == 1;
}