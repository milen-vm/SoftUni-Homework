<?php
include_once 'Room.class.php';

class Apartment extends Room {
    
    function __construct($roomNumber, $price) {
        parent::__construct(RoomType::Diamond, TRUE, TRUE, 4, $roomNumber,
            ['TV', 'air-conditioner', 'refrigerator', 'mini-bar', 'bathtub', 'kitchen box', 'free Wi-Fi'], $price);
    }
}
?>