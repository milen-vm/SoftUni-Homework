<?php
include_once 'RoomInfo.class.php';
include_once 'iReservable.class.php';
include_once 'Reservation.class.php';


abstract class Room implements iReservable {
    private $roomInfo;
    private $reservations;

    function __construct($roomType, $hasRestRoom, $hasBalcony, $bedCount, $roomNumber, $extras, $price) {
        $this->roomInfo = new RoomInfo($roomType, $hasRestRoom, $hasBalcony, $bedCount, $roomNumber, $extras, $price);
        $this->reservations = [];
    }
    
    /*
     * @return string
     */
    public function getRoomInfo() {
        return $this->roomInfo;
    }

    /*
     * @param string $roomInfo
     */
    public function setRoomInfo($roomInfo) {
        $this->roomInfo = $roomInfo;
    }
    
    /*
     * @return object
     */ 
    public function getReservations() {
        return $this->reservations;
    }
     
    function __toString() {
        return $this->roomInfo . '<br />' .
            'Reservations: ' . implode(', ', $this->reservations);
    }

    function addReservation(Reservation $newReservation) {
        $newResStartDate = $newReservation->getStartDate();
        $newResEndDate = $newReservation->getEndDate();
        if (sizeof($this->reservations) > 0) {
            foreach ($this->reservations as $currentReservation) {
                $currentResStartDate = $currentReservation->getStartDate();
                $currentResEndDate = $currentReservation->getEndDate();
                
                if ($currentResStartDate < $newResStartDate) {
                    if ($currentResEndDate < $newResStartDate) {
                        $this->reservations[] = $newReservation;
                    } else {
                        throw new EReservationException('Reservation overlap.');
                    }
                    
                } else if($currentResStartDate > $newResStartDate) {
                    if ($newResEndDate < $currentResStartDate) {
                        $this->reservations[] = $newReservation;
                    } else {
                        throw new EReservationException('Reservation overlap.');
                    }
                    
                } else {
                    throw new EReservationException('Reservation overlap.');
                }
            }
        } else {
            $this->reservations[] = $newReservation;
        }
    }

    function removeReservation(Reservation $reservation) {
        $startDate = $reservation->getStartDate();
        $endDate = $reservation->getEndDate();
        $count = sizeof($this->reservations);
        for ($i=0; $i < $count; $i++) {
            $currentReservation = $this->reservations[$i];
            if ($currentReservation->getStartDate == $startDate &&
                $currentReservation->getEndDate == $endDate) {
                unset($this->reservations[$i]);
                return;
            }
        }
        
        throw EReservationException('Invalid reservation.');
    }
}
?>