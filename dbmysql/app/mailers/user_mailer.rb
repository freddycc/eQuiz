class UserMailer < ActionMailer::Base
  default :from => "contabilidad.info.cr@gmail.com"
  def registration_confirmation(estudiantes)
  mail(:to => estudiantes.correo, :subject => "Aviso")
  end
end
