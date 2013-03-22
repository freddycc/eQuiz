class Profesore < ActiveRecord::Base
  attr_accessible :cedula, :nombre, :apellidos, :email, :username, :password
end
