class EstudiantesController < ApplicationController
  # GET /estudiantes
  # GET /estudiantes.json
  def index
    @estudiantes = Estudiante.all

    respond_to do |format|
      if @estudiantes.empty?
        format.html # index.html.erb
        format.json { head :no_content }
        format.xml { head :no_content }
      else     
        format.html # index.html.erb   
        format.json { render json: @estudiantes }
        format.xml { render xml: @estudiantes }
      end
    end
  end

  # GET /estudiantes/1
  # GET /estudiantes/1.json
  def show
    @estudiante = Estudiante.find(params[:id])

    respond_to do |format|
      format.html # show.html.erb
      format.json { render json: @estudiante }
    end
  end
  
  # GET /estudiantes/new
  # GET /estudiantes/new.json
  def new
    @estudiante = Estudiante.new

    respond_to do |format|
      format.html # new.html.erb
      format.json { render json: @estudiante }
    end
  end
  
  # POST /estudiantes
  # POST /estudiantes.json
  def add
    @estudiante =  Estudiante.new
    @estudiante.nombre = params[:nombre]
    @estudiante.email = params[:email]
    @estudiante.apellidos = params[:apellidos]
    @estudiante.password = params[:password]
    @estudiante.cedula = params[:cedula]
    @estudiante.username = params[:username]

    respond_to do |format|
      if @estudiante.save
        format.json { render json: @estudiante, notice: 'Estudiante was successfully created.' }
        format.xml { render xml: @estudiante, status: :created, location: @estudiante }
      else
        format.json { render json: @estudiante.errors, status: :unprocessable_entity }
      end
    end
  end

  # GET /estudiantes/1/edit
  def edit
    @estudiante = Estudiante.find(params[:id])
  end

  
  # Codigo sin utilizar
  def create
    @estudiante = Estudiante.new(params[:estudiante])

    respond_to do |format|
      if @estudiante.save
        format.html { redirect_to @estudiante, notice: 'Estudiante was successfully created.' }
        format.json { render json: @estudiante, status: :created, location: @estudiante }
      else
        format.html { render action: "new" }
        format.json { render json: @estudiante.errors, status: :unprocessable_entity }
      end
    end
  end

  # PUT /estudiantes/1
  # PUT /estudiantes/1.json
  def update
    @estudiante = Estudiante.find(params[:id])
    @estudiante.nombre = params[:nombre]
    @estudiante.email = params[:email]
    @estudiante.apellidos = params[:apellidos]
    @estudiante.password = params[:password]
    @estudiante.cedula = params[:cedula]
    @estudiante.username = params[:username]
    respond_to do |format|
      if @estudiante.update_attributes(params[:estudiante])
        format.html { redirect_to @estudiante, notice: 'Estudiante was successfully updated.' }
        format.json { render json: @estudiante, status: :created }
      else
        format.html { render action: "edit" }
        format.json { head :no_content }
      end
    end
  end

  # DELETE /estudiantes/1
  # DELETE /estudiantes/1.json
  def destroy
    @estudiante = Estudiante.find(params[:id])
    @estudiante.destroy

    respond_to do |format|
      format.html { redirect_to estudiantes_url }
      format.json { head :no_content }
    end
  end
end
