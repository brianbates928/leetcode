class MyQueue {
    private stackPush: number[];
    private stackPop: number[];

    constructor() {
        this.stackPush = [];
        this.stackPop = [];
    }

    push(x: number): void {
        this.stackPush.push(x);
    }

    pop(): number {
        this.peek();
        return this.stackPop.pop() as number;
    }

    peek(): number {
        if (this.stackPop.length === 0) {
            while (this.stackPush.length > 0) {
                this.stackPop.push(this.stackPush.pop() as number);
            }
        }
        return this.stackPop[this.stackPop.length - 1];
    }

    empty(): boolean {
        return this.stackPush.length === 0 && this.stackPop.length === 0;
    }
}
