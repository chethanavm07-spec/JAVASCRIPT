* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

body {
    font-family: Arial, Helvetica, sans-serif;
    background: #f1f5f9;
    color: #182235;
}


/* HEADER */

.header {
    height: 135px;
    background: white;

    display: flex;
    align-items: center;
    justify-content: space-between;

    padding: 20px 6%;

    border-bottom: 1px solid #e5e7eb;
}


.logo {
    display: flex;
    flex-direction: column;
}


.logo span {
    font-size: 46px;
    font-weight: bold;
    color: #2864d7;
    letter-spacing: -3px;
}


.logo small {
    font-size: 8px;
    color: #777;
    letter-spacing: 1px;
}


/* BUTTONS */

.refresh-btn {
    width: 55px;
    height: 55px;

    border-radius: 50%;
    border: 1px solid #e1e7ef;

    background: white;
    color: #2864d7;

    font-size: 28px;
    cursor: pointer;
}


.menu-btn {
    width: 60px;
    height: 60px;

    border: none;
    border-radius: 14px;

    background: #eef5ff;
    color: #2864d7;

    font-size: 28px;
    cursor: pointer;
}


/* MENU */

.menu {
    display: none;

    position: fixed;

    right: 20px;
    top: 110px;

    width: 200px;

    background: white;

    padding: 15px;

    border-radius: 10px;

    box-shadow: 0 5px 20px rgba(0,0,0,.15);

    z-index: 100;
}


.menu.show {
    display: flex;
    flex-direction: column;
}


.menu a {
    text-decoration: none;
    color: #333;

    padding: 12px;

    border-bottom: 1px solid #eee;
}


/* MAIN */

.container {
    width: 100%;
    max-width: 900px;

    margin: 30px auto;

    padding: 0 20px;
}


/* APPLICATION */

.app-card {
    background: white;

    padding: 30px;

    border-radius: 15px;

    border: 1px solid #e0e6ed;

    box-shadow: 0 2px 8px rgba(0,0,0,.04);
}


.app-card h1 {
    color: #182235;

    margin-bottom: 25px;

    font-size: 28px;
}


/* ADD TASK */

.add-section {
    display: flex;

    gap: 10px;

    margin-bottom: 25px;
}


#taskInput {
    flex: 1;

    padding: 14px;

    border: 1px solid #ccd5e0;

    border-radius: 8px;

    font-size: 16px;

    outline: none;
}


#taskInput:focus {
    border-color: #2864d7;
}


.add-section button {
    border: none;

    background: #2864d7;

    color: white;

    padding: 12px 22px;

    border-radius: 8px;

    font-weight: bold;

    cursor: pointer;
}


/* FILTERS */

.filters {
    display: flex;

    gap: 10px;

    margin-bottom: 20px;
}


.filter {
    border: 1px solid #d5dce5;

    background: white;

    color: #526074;

    padding: 10px 18px;

    border-radius: 20px;

    cursor: pointer;
}


.filter.active {
    background: #2864d7;

    color: white;

    border-color: #2864d7;
}


/* TASK */

#taskList {
    list-style: none;
}


.task {
    display: flex;

    align-items: center;

    justify-content: space-between;

    gap: 10px;

    padding: 15px;

    margin-bottom: 10px;

    background: #f8fafc;

    border: 1px solid #e3e8ee;

    border-radius: 10px;
}


.task-left {
    display: flex;

    align-items: center;

    gap: 12px;

    flex: 1;
}


.task-left input {
    width: 19px;
    height: 19px;
}


.task-text {
    font-size: 16px;

    word-break: break-word;
}


.task.completed .task-text {
    text-decoration: line-through;

    color: #8b95a5;
}


/* TASK ACTIONS */

.actions {
    display: flex;

    gap: 6px;
}


.actions button {
    border: none;

    padding: 8px 11px;

    border-radius: 6px;

    cursor: pointer;
}


.edit {
    background: #fff4d6;

    color: #9a6900;
}


.delete {
    background: #ffe3e3;

    color: #c32929;
}


/* EMPTY */

.empty {
    text-align: center;

    color: #8a94a3;

    padding: 25px;
}


/* INFO */

.info-card {
    background: white;

    margin-top: 25px;

    padding: 30px;

    border-radius: 15px;

    border: 1px solid #e0e6ed;
}


.info-card h2 {
    font-size: 25px;

    margin-bottom: 15px;
}


.info-card p {
    color: #526074;

    line-height: 1.7;
}


.features h3 {
    margin-top: 20px;

    color: #2864d7;
}


.features ul {
    margin-top: 10px;

    padding-left: 25px;

    color: #526074;

    line-height: 1.8;