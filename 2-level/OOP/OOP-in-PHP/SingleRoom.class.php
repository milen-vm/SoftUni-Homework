<?php
include_once 'Room.class.php';

class SingleRoom extends Room {
    
    function __construct($roomNumber, $price) {
        parent::__construct(RoomType::Standart, TRUE, FALSE, 1, $roomNumber, ['TV', 'air-conditioner'], $price);
    }
}
?>