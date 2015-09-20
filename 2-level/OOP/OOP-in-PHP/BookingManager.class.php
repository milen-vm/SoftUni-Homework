<?php
require_once 'RoomInfo.class.php';
require_once 'Room.class.php';
require_once 'SingleRoom.class.php';
class BookingManager {
    
    static function bookRoom(Room $room, Reservation $reservation) {
        $room->addReservation($reservation);
        $roomInfo = $room->getRoomInfo();
        // $roomInfo = new RoomInfo('Standart', TRUE, TRUE, 2, 1452, [], 50);
        // echo $roomInfo->getRoomNumber();
        var_dump($roomInfo);
        echo "Room <strong>$roomInfo->getRoomNumber()</strong>";// successfully booked for <strong>Svetlin Nakov</strong> from <time>24.10.2014</time> to <time>26.10.2014</time>!
    }
} 
?>