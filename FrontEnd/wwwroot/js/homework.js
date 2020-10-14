
// isNaN 是不是一个非数字值,true表示不是数字,false表示是数字
var weeks = 'sad';
if (isNaN(weeks)) {
    console.log(`${weeks}不是数字`);
} else if (weeks > 25 || weeks < 0) {
    console.log("`${weeks}只能在0和25之间`");
} else {
    if (weeks < 25) {
        console.log("学费比较贵")
    }
}

var time = new Date("12 / 12 / 2020  11: 11: 11");
console.log(time);


// 用当前时间戳来测试代码执行的性能
var start = Date.now();
for (var i = 0; i < 100; i++) {
    console.log(i);
}
var end = Date.now();
console.log("for循环用时" + (end - start) + "毫秒");


// 另一种方法 console.time()  console.timeEnd();]

console.time('1123');
for (var i = 0; i < 100; i++) {
    console.log(i);
}
console.timeEnd('1123');