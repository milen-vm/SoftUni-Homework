<?php

class RoomInfo {
    private $roomType;
    private $hasRestRoom;
    private $hasBalcony;
    private $bedCount;
    private $roomNumber;
    private $extras;
    private $price;

    function __construct($roomType, $hasRestRoom, $hasBalcony, $bedCount, $roomNumber, $extras, $price) {
        $this->setRoomType($roomType);
        $this->setHasRestRoom($hasRestRoom);
        $this->setHasBalcony($hasBalcony);
        $this->setBedCount($bedCount);
        $this->setRoomNumber($roomNumber);
        $this->setExtras($extras);
        $this->setPrice($price);
    }

    public function getRoomType() {
        return $this->roomType;
    }

    public function setRoomType($roomType) {
        $this->roomType = $roomType;
    }

    public function getHasRestRoom() {
        return $this->hasRestRoom;
    }

    public function setHasRestRoom($hasRestRoom) {
        $this->hasRestRoom = $hasRestRoom;
    }

    public function getHasBalcony() {
        return $this->hasBalcony;
    }

    public function setHasBalcony($hasBalcony) {
        $this->hasBalcony = $hasBalcony;
    }

    public function getBedCount() {
        return $this->bedCount;
    }

    public function setBedCount($bedCount) {
        $this->bedCount = $bedCount;
    }

    public function getRoomNumber() {
        return $this->roomNumber;
    }

    /*
     * @param int $roomNumber
     */
    public function setRoomNumber($roomNumber) {
        $this->roomNumber = $roomNumber;
    }

    public function getExtras() {
        return $this->extras;
    }

    public function setExtras($extras) {
        $this->extras = $extras;
    }

    public function getPrice() {
        return $this->price;
    }

    public function setPrice($price) {
        $this->price = $price;
    }

    public function getTypes() {
        return $this->types;
    }

    function __toString() {
        $hasBalcony = $this->hasBalcony ? 'Yes' : 'No';
        $hasRestRoom = $this->hasRestRoom ? 'Yes' : 'No';

        return "Room informatio - Type: $this->roomType, Has restroom: $hasRestRoom, " . "Has bolcony: $hasBalcony, Bed count: $this->bedCount, Room number: $this->roomNumber, " . "Extras: [" . implode(', ', $this->extras) . "], Price: $this->price";
    }
}
?>