#pragma strict

var speedX: float = 30.0;
var speedY: float = 40.0;
var speedZ: float = 50.0;

function Start () {

}

function Update () {
    var d = Time.deltaTime;
    Debug.Log(d);
    transform.Rotate(speedX * d, speedY * d, speedZ * d, Space.Self);
}
