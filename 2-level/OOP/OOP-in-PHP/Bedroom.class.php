<?php
include_once 'Room.class.php';

class Bedroom extends Room {
    function __construct($roomNumber, $price) {
        parent::__construct(RoomType::Gold, TRUE, TRUE, 2, $roomNumber,
            ['TV', 'air-conditioner', 'refrigerator', 'mini-bar', 'bathtub'], $price);
    }
}
?>