class RandomizedSet {
    private map: Map<number, number>;
    private arr: number[];
  
    constructor() {
        this.map = new Map();
        this.arr = [];
    }
  
    insert(val: number): boolean {
        if (!this.map.has(val)) {
            this.map.set(val, this.arr.length);
            this.arr.push(val);
            return true;
        }
        return false;
    }
  
    remove(val: number): boolean {
        if (this.map.has(val)) {
            let lastElement = this.arr[this.arr.length - 1];
            let idx = this.map.get(val)!;
            this.arr[idx] = lastElement;
            this.map.set(lastElement, idx);
            this.arr.pop();
            this.map.delete(val);
            return true;
        }
        return false;
    }
  
    getRandom(): number {
        let randomIdx = Math.floor(Math.random() * this.arr.length);
        return this.arr[randomIdx];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * var obj = new RandomizedSet()
 * var param_1 = obj.insert(val)
 * var param_2 = obj.remove(val)
 * var param_3 = obj.getRandom()
 */
