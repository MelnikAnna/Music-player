﻿body
{
    background - color: #9cb9d1;
    color: #094d74;
    font - family: 'Roboto', sans - serif;
}

# myProgress {
width: 420px;
background - color: #eef0f6;
    cursor: pointer;
border - radius: 10px;
}

#myBar {
    width: 0 %;
height: 5px;
background - color: #9cb9d1;
    border - radius: 10px;
}

.logo
{
    fill: red;
}

.btn - action {
    cursor: pointer;
    padding - top: 10px;
    width: 30px;
}

.btn - ctn, .infos - ctn {
    display: flex;
    align - items: center;
    justify - content: center;
}

.infos - ctn {
    padding - top: 20px;
}

.btn - ctn > div {
    padding: 5px;
    margin - top: 18px;
    margin - bottom: 18px;
}

.infos - ctn > div {
    margin - bottom: 8px;
    color: #9cb9d1;
}

.first - btn {
    margin - left: 3px;
}

.duration
{
    margin - left: 10px;
}

.title
{
    margin - left: 10px;
    width: 210px;
    text - align: center;
}

.player - ctn {
    border - radius: 15px;
    width: 420px;
    padding: 10px;
    background - color: #373737;
    margin: auto;
    margin - top: 100px;
}

.playlist - track - ctn {
    display: flex;
    background - color: #094d74;
    margin - top: 3px;
    border - radius: 5px;
    cursor: pointer;
}

    .playlist - track - ctn:last - child {
    /*border: 1px solid #ffc266; */
}

    .playlist - track - ctn > div {
    margin: 10px;
}

.playlist - info - track {
    width: 80 %;
}

.playlist - info - track, .playlist - duration {
    padding - top: 7px;
    padding - bottom: 7px;
    color: #094d74;
    font - size: 14px;
    pointer - events: none;
}

.playlist - ctn {
    padding - bottom: 20px;
}

.active - track {
    background: #094d74;
    color: #ffc266 !important;
    font - weight: bold;
}

    .active - track > .playlist - info - track, .active - track > .playlist - duration, .active - track > .playlist - btn - play {
    color: #ffc266 !important;
    }


.playlist - btn - play {
    pointer - events: none;
    padding - top: 5px;
    padding - bottom: 5px;
}

.fas
{
    color: #cfdaec;
    font - size: 20px;
}
