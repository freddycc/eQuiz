class Estudiante < ActiveRecord::Base
  attr_accessible :apellidos, :cedula, :email, :id, :nombre, :password, :username
end
