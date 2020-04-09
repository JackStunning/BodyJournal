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
    if (armToggle === false){
      $(".arms").css("fill", "#555");
      armToggle = true;
    } else {
      $(".arms").css("fill", "#FF0002");
      armToggle = false;
    }
  });

  let shoulderToggle = false;
  $("#shoulders").click(function(event){
    event.preventDefault();
    if (shoulderToggle === false){
      $(".shoulders").css("fill", "#555");
      shoulderToggle = true;
    } else {
      $(".shoulders").css("fill", "#A52A2A");
      shoulderToggle = false;
    }
  });

  let chestToggle = false;
  $("#chest").click(function(event){
    event.preventDefault();
    if (chestToggle === false){
      $(".chest").css("fill", "#555");
      chestToggle = true;
    } else {
      $(".chest").css("fill", "#800080");
      chestToggle = false;
    }
  });
  
  let backToggle = false;
  $("#back").click(function(event){
    event.preventDefault();
    if (backToggle === false){
      $(".back").css("fill", "#555");
      backToggle = true;
    } else {
      $(".back").css("fill", "#0000F0");
      backToggle = false;
    }
  });
  
  let coreToggle = false;
  $("#core").click(function(event){
    event.preventDefault();
    if (coreToggle === false){
      $(".core").css("fill", "#555");
      coreToggle = true;
    } else {
      $(".core").css("fill", "#228B22");
      coreToggle = false;
    }
  });
  
  let legsToggle = false;
  $("#legs").click(function(event){
    event.preventDefault();
    if (legsToggle === false){
      $(".legs").css("fill", "#555");
      legsToggle = true;
    } else {
      $(".legs").css("fill", "#FFA500");
      legsToggle = false;
    }
  });
})