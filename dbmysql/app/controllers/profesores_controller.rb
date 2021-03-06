class ProfesoresController < ApplicationController
  # GET /profesores
  # GET /profesores.json
  def index
    @profesores = Profesore.all

    respond_to do |format|
      if @profesores.empty?
        format.html # index.html.erb
        format.json { head :no_content }
        format.xml { head :no_content }
      else
        format.html # index.html.erb
        format.json { render json: @profesores }
        format.xml { render xml: @profesores }
      end
    end
  end

  # GET /profesores/1
  # GET /profesores/1.json
  def show
    @profesore = Profesore.find(params[:id])

    respond_to do |format|
      format.html # show.html.erb
      format.json { render json: @profesore }
    end
  end

  def getcursos
    @profesore = Profesore.find(params[:profe_id])
    @cursos = @profesore.cursos

    respond_to do |format|
      if @cursos.empty?
        format.html # index.html.erb
        format.json { head :no_content }
        format.xml { head :no_content }
      else
        format.html # index.html.erb
        format.json { render json: @cursos }
        format.xml { render xml: @cursos }
      end
    end
  end

  def prof
    @profesore = Profesore.where(:username => params[:username], :password => params[:password])
   respond_to do |format|
    if @profesore.empty?
       format.html # index.html.erb
        format.json { head :no_content }
        format.xml { head :no_content }
      else
        format.html # index.html.erb
        format.json { render json: @profesore }
        format.xml { render xml: @profesore }
      end
    end
  end  

  def add
    @profesore = Profesore.new
    @profesore.nombre = params[:nombre]
    @profesore.apellidos = params[:apellidos]
    @profesore.cedula = params[:cedula]
    @profesore.email = params[:email]
    @profesore.password = params[:password]
    @profesore.username = params[:username]
    
    respond_to do |format|
      if @profesore.save
        format.json { render json: @profesore, notice: 'created' }
      else
        format.json { render json: @profesore.errors }
      end
    end
    #@profesore.save
  end
  # GET /profesores/new
  # GET /profesores/new.json
  def new
    @profesore = Profesore.new

    respond_to do |format|
      format.html # new.html.erb
      format.json { render json: @profesore }
    end
  end

  # GET /profesores/1/edit
  def edit
    @profesore = Profesore.find(params[:id])
  end

  # POST /profesores
  # POST /profesores.json
  def create
    @profesore = Profesore.new(params[:profesore])

    respond_to do |format|
      if @profesore.save
        format.html { redirect_to @profesore, notice: 'Profesore was successfully created.' }
        format.json { render json: @profesore, status: :created, location: @profesore }
      else
        format.html { render action: "new" }
        format.json { render json: @profesore.errors, status: :unprocessable_entity }
      end
    end
  end

  # PUT /profesores/1
  # PUT /profesores/1.json
  def update
    @profesore = Profesore.find(params[:id])
    @profesore.nombre = params[:nombre]
    @profesore.apellido = params[:apellidos]
    @profesore.cedula = params[:cedula]
    @profesore.email = params[:email]
    @profesore.password = params[:password]
    @profesore.username = params[:username]
    respond_to do |format|
      if @profesore.update_attributes(params[:profesore])
        format.html { redirect_to @profesore, notice: 'Profesore was successfully updated.' }
        format.json { render json: @profesore, status: :created }
      else
        format.html { render action: "edit" }
        format.json { head :no_content}#json: @profesore.errors, status: :unprocessable_entity }
      end
    end
  end

  # DELETE /profesores/1
  # DELETE /profesores/1.json
  def destroy
    @profesore = Profesore.find(params[:id])
    @profesore.destroy

    respond_to do |format|
      format.html { redirect_to profesores_url }
      format.json { head :no_content }
    end
  end
end
