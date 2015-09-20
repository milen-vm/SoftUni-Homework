<?php
function __autoload($className) {
    require_once('./' . $className . '.class.php');
}

$room = new SingleRoom(1408, 99);
$guest = new Guest("Svetlin", "Nakov", 8003224277);
$startDate = strtotime("24.10.2014");
$endDate = strtotime("26.10.2014");
$reservation = new Reservation($startDate, $endDate, $guest);
// $rInfo = $room->getRoomInfo();
// echo $room->getRoomInfo()->getRoomNumber();
// $roomInfo = new RoomInfo('Standart', TRUE, TRUE, 2, 1452, [], 50);
// echo $roomInfo->getRoomNumber();
BookingManager::bookRoom($room, $reservation);
// BookingManager::bookRoom($room, $reservation);
?>