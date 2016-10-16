function longestSubstring(str) {
	var last = "";
  var n = 1;
  var max = 0;
	for(var i=0; i<str.length; i++){
  	var cur = str.charAt(i);
    if(cur === "1"){
    	if(cur ===  last){
    		n++;
       	if(i === str.length -1){
       		if(n > max){
        		max = n;
        	}
        }
      } else {
      	if(n > max){
        	max = n;
        }
        n = 1;
      }
    }
    last = cur;
  }
  return max;
}

(function(testFunction) {
  var testCases = [
    {
      input: "010101111011000011100101",
      expected: 4
    }, {
      input: "00000000",
      expected: 0
    }, {
      input: "101010101010",
      expected: 1
    }, {
      input: "11111",
      expected: 5
    }, {
      input: "1111101111101110111111",
      expected: 6
    }
  ];

  var correct = true;

  for(var i = 0; i < testCases.length; i++) {
    try {
      var result = testFunction(testCases[i].input);
      if(result != testCases[i].expected) {
        alert('Failed test case #' + i + ', produced result "' + result + '" instead of expected "' + testCases[i].expected + '"');
        correct = false;
      }
    } catch(err) {
      alert('Failed test case #' + i + ', function threw an exception.');
      correct = false;
    }
  }

  if(correct)
    alert('All test cases passed!');
})(longestSubstring);
