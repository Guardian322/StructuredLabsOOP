#include <iostream>
#include <conio.h>

template<typename T>
struct Box {
public:
    T znach;
private:
    Box* next;
    Box* prev;
    Box() {
        znach = 0;
        printf("Box()");
    }
    Box(int x) {
        znach = x;
        printf("Box(int x)");
    }
    Box(Box& b) {
        znach = b.znach;
        printf("Box(&)");
    }
    ~Box() {
        printf("~Box()");
    }
};

template<typename T>
class spisok2sv {
private:
    Box* first;
    Box* last;
    spisok2sv() {
        first = last = 0;
    }
    void add(T x) {
        Box* buffer = new Box;
        buffer.znach = x;
    }

};





int main()
{

}
