<?php
include_once 'Guest.class.php';

class Reservation {
    private $startDate;
    private $endDate;
    private $guest;

    function __construct($startDate, $endDate, Guest $guest) {
        $this->setStartDate($startDate);
        $this->setEndDate($endDate);
        $this->setGuest($guest);
    }

    public function getStartDate() {
        return $this->startDate;
    }

    public function setStartDate($startDate) {
        $this->startDate = $startDate;
    }

    public function getEndDate() {
        return $this->endDate;
    }

    public function setEndDate($endDate) {
        $this->endDate = $endDate;
    }

    public function getGuest($value = '') {
        return $this->guest;
    }

    public function setGuest(Guest $guest) {
        $this->guest = $guest;
    }
    
    function __toString()
    {
        return "[Start date: $this->startDate, End date: $this->endDate, $this->guest]<br />";
    }

}
?>