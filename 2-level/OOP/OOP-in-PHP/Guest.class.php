<?php

class Guest {
    private $firstName;
    private $lastName;
    private $id;

     /*
      * @param string $firstName
      * @param string $lastName
      * @param int $id
     */
    function __construct($firstName, $lastName, $id) {
        $this -> firstName = $firstName;
        $this -> lastName = $lastName;
        $this -> id = $id;
    }

    /*
     * @return string
     */
    public function getFirstName() {
        return $this -> firstName;
    }

    /*
     * @param string $firstName
     */
    public function setFirstName($firstName) {
        $this -> firstName = $firstName;
    }

    /*
     * @return string
     */
    public function getLastName() {
        return $this -> lastName;
    }
    
    /*
     * @param string $lastName
     */
    public function setLastName($lastName) {
        $this -> lastName = $lastName;
    }

    /*
     * @return string
     */
    public function getId() {
        return $this -> id;
    }

    /*
     * @param string $id
     */
    public function setId($id) {
        $this -> id = $id;
    }
    
    function __toString() {
        return "Guest: $this->firstName $this->lastName EGN: $this->id";
    }
}
?>