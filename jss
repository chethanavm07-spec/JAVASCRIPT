// Store tasks in an array

let tasks =
    JSON.parse(localStorage.getItem("tasks")) || [];


// Current filter

let currentFilter = "all";


// Display tasks when page opens

renderTasks();


// -----------------------------
// ADD TASK
// -----------------------------

function addTask() {

    const input =
        document.getElementById("taskInput");

    const text =
        input.value.trim();


    if (text === "") {

        alert("Please enter a task.");

        return;
    }


    const newTask = {

        id: Date.now(),

        text: text,

        completed: false

    };


    tasks.push(newTask);


    saveTasks();


    input.value = "";


    renderTasks();
}


// -----------------------------
// DISPLAY TASKS
// -----------------------------

function renderTasks() {

    const list =
        document.getElementById("taskList");

    const empty =
        document.getElementById("emptyMessage");


    list.innerHTML = "";


    let filteredTasks = tasks;


    // FILTER

    if (currentFilter === "active") {

        filteredTasks =
            tasks.filter(
                task => !task.completed
            );

    }


    if (currentFilter === "completed") {

        filteredTasks =
            tasks.filter(
                task => task.completed
            );

    }


    // EMPTY

    if (filteredTasks.length === 0) {

        empty.style.display = "block";

        return;

    }


    empty.style.display = "none";


    // CREATE DOM ELEMENTS

    filteredTasks.forEach(task => {

        const li =
            document.createElement("li");


        li.className =
            task.completed
                ? "task completed"
                : "task";


        li.innerHTML = `

            <div class="task-left">

                <input
                    type="checkbox"
                    ${task.completed ? "checked" : ""}
                    onchange="toggleTask(${task.id})"
                >

                <span class="task-text">
                    ${escapeHTML(task.text)}
                </span>

            </div>


            <div class="actions">

                <button
                    class="edit"
                    onclick="editTask(${task.id})">
                    Edit
                </button>

                <button
                    class="delete"
                    onclick="deleteTask(${task.id})">
                    Delete
                </button>

            </div>

        `;


        list.appendChild(li);

    });

}


// -----------------------------
// UPDATE TASK STATUS
// -----------------------------

function toggleTask(id) {

    const task =
        tasks.find(
            task => task.id === id
        );


    if (task) {

        task.completed =
            !task.completed;

        saveTasks();

        renderTasks();

    }

}


// -----------------------------
// EDIT TASK
// -----------------------------

function editTask(id) {

    const task =
        tasks.find(
            task => task.id === id
        );


    if (!task) return;


    const newText =
        prompt(
            "Edit your task:",
            task.text
        );


    if (
        newText !== null &&
        newText.trim() !== ""
    ) {

        task.text =
            newText.trim();

        saveTasks();

        renderTasks();

    }

}


// -----------------------------
// DELETE TASK
// -----------------------------

function deleteTask(id) {

    const confirmation =
        confirm(
            "Do you want to delete this task?"
        );


    if (!confirmation) return;


    tasks =
        tasks.filter(
            task => task.id !== id
        );


    saveTasks();

    renderTasks();

}


// -----------------------------
// FILTER
// -----------------------------

function setFilter(filter, button) {

    currentFilter = filter;


    document
        .querySelectorAll(".filter")
        .forEach(btn => {

            btn.classList.remove("active");

        });


    button.classList.add("active");


    renderTasks();

}


// -------------------