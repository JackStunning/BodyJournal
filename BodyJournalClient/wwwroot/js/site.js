// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.querySelectorAll(".muscle-groups svg g g[id]").forEach(function(group) {
  // For the hover
  group.addEventListener('mouseover', function(el) {
    let id = el.path[1].id.toLowerCase()
    if(!id) id = el.path[2].id.toLowerCase()
    let label = document.querySelectorAll("label[for=" + id + "]")[0]
    if (label.classList)
      label.classList.add("hover")
    else
      label.className += ' ' + "hover"
  })
  group.addEventListener('mouseout', function(el) {
    let id = el.path[1].id.toLowerCase()
    if(!id) id = el.path[2].id.toLowerCase()
    let label = document.querySelectorAll("label[for=" + id + "]")[0]
    let clss = "hover"
    if (label.classList)
      label.classList.remove(clss)
    else
      label.className = label.className.replace(new RegExp('(^|\\b)' + clss.split(' ').join('|') + '(\\b|$)', 'gi'), ' ')
  })
  // For the click
  group.addEventListener('click', function(el) {
    let id = el.path[1].id.toLowerCase()
    if(!id) id = el.path[2].id.toLowerCase()
    let input = document.getElementById(id)
    if(input.checked) input.checked = false
    else input.checked = true
  });
  //Toggle functions
  let armToggle = false;
  $("#arms").click(function(event){
    event.preventDefault();
    if (armToggle === true){
      $(".arms").css("fill", "#555");
      armToggle = false;
    } else {
      $(".arms").css("fill", "#FF0002");
      armToggle = true;
    }
  });

  let shoulderToggle = false;
  $("#shoulders").click(function(event){
    event.preventDefault();
    if (shoulderToggle === true){
      $(".shoulders").css("fill", "#555");
      shoulderToggle = false;
    } else {
      $(".shoulders").css("fill", "#A52A2A");
      shoulderToggle = true;
    }
  });

  let chestToggle = false;
  $("#chest").click(function(event){
    event.preventDefault();
    if (chestToggle === true){
      $(".chest").css("fill", "#555");
      chestToggle = false;
    } else {
      $(".chest").css("fill", "#800080");
      chestToggle = true;
    }
  });
  
  let backToggle = false;
  $("#back").click(function(event){
    event.preventDefault();
    if (backToggle === true){
      $(".back").css("fill", "#555");
      backToggle = false;
    } else {
      $(".back").css("fill", "#0000F0");
      backToggle = true;
    }
  });
  
  let coreToggle = false;
  $("#core").click(function(event){
    event.preventDefault();
    if (coreToggle === true){
      $(".core").css("fill", "#555");
      coreToggle = false;
    } else {
      $(".core").css("fill", "#228B22");
      coreToggle = true;
    }
  });
  
  let legsToggle = false;
  $("#legs").click(function(event){
    event.preventDefault();
    if (legsToggle === true){
      $(".legs").css("fill", "#555");
      legsToggle = false;
    } else {
      $(".legs").css("fill", "#FFA500");
      legsToggle = true;
    }
  });

  //Muscle Fatigue colors
  let armMuscleFatigue = 5
  if (armMuscleFatigue === 0){
    $(".arms").css("fill", "#555");
  } else if(armMuscleFatigue === 1){
    $(".arms").css("fill", "#7d4141");
  } else if(armMuscleFatigue <= 3){
    $(".arms").css("fill", "#af3737");
  } else if(armMuscleFatigue <= 5){
    $(".arms").css("fill", "#f51414");
  }

  let shoulderMuscleFatigue = 3
  if (shoulderMuscleFatigue === 0){
    $(".shoulders").css("fill", "#555");
  } else if(shoulderMuscleFatigue === 1){
    $(".shoulders").css("fill", "#7d4141");
  } else if(shoulderMuscleFatigue <= 3){
    $(".shoulders").css("fill", "#af3737");
  } else if(shoulderMuscleFatigue <= 5){
    $(".shoulders").css("fill", "#f51414");
  }

  let chestMuscleFatigue = 3
  if (chestMuscleFatigue === 0){
    $(".chest").css("fill", "#555");
  } else if(chestMuscleFatigue === 1){
    $(".chest").css("fill", "#7d4141");
  } else if(chestMuscleFatigue <= 3){
    $(".chest").css("fill", "#af3737");
  } else if(chestMuscleFatigue <= 5){
    $(".chest").css("fill", "#f51414");
  }

  let backMuscleFatigue = 1
  if (backMuscleFatigue === 0){
    $(".back").css("fill", "#555");
  } else if(backMuscleFatigue === 1){
    $(".back").css("fill", "#7d4141");
  } else if(backMuscleFatigue <= 3){
    $(".back").css("fill", "#af3737");
  } else if(backMuscleFatigue <= 5){
    $(".back").css("fill", "#f51414");
  }

  let coreMuscleFatigue = 0
  if (coreMuscleFatigue === 0){
    $(".core").css("fill", "#555");
  } else if(coreMuscleFatigue === 1){
    $(".core").css("fill", "#7d4141");
  } else if(coreMuscleFatigue <= 3){
    $(".core").css("fill", "#af3737");
  } else if(coreMuscleFatigue <= 5){
    $(".core").css("fill", "#f51414");
  }

  let legMuscleFatigue = 0
  if (legMuscleFatigue === 0){
    $(".legs").css("fill", "#555");
  } else if(legMuscleFatigue === 1){
    $(".legs").css("fill", "#7d4141");
  } else if(legMuscleFatigue <= 3){
    $(".legs").css("fill", "#af3737");
  } else if(legMuscleFatigue <= 5){
    $(".legs").css("fill", "#f51414");
  }
})