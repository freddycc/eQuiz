class Profesore < ActiveRecord::Base
  attr_accessible :apellido, :cedula, :email, :nombre, :password, :username
end
