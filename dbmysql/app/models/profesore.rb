class Profesore < ActiveRecord::Base
  attr_accessible :cedula, :nombre, :apellidos, :email, :username, :password

  has_many :cursos, :dependent => :destroy
end
