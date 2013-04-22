class PruebasController < ApplicationController
  # GET /pruebas
  # GET /pruebas.json
  def index
    @pruebas = Prueba.all

    respond_to do |format|
      format.html # index.html.erb
      format.json { render json: @pruebas }
      format.xml { render xml: @pruebas }
    end
  end

  # GET /pruebas/1
  # GET /pruebas/1.json
  # GET /pruebas/1.xml
  def show
    @prueba = Prueba.find(params[:id])

    respond_to do |format|
      format.html # show.html.erb
      format.json { render json: @prueba }
      format.xml { render xml: @prueba }
    end
  end

  #GET /cursos/1/activas.xml
  def activas
    @curso = Curso.find(params[:id])
    @pruebas = @curso.pruebas
    respond_to do |format|
      if @pruebas.empty?
        format.xml { head :no_content }
      else
        @pruebas.each do |prueba|
          if prueba.estado == 'inactiva'
            prueba.nombre = nil
            prueba.comentario = nil
            prueba.fecha = nil
            prueba.preguntas = nil
            prueba.estado = nil
            prueba.duracion = nil
          end
        end
        format.xml { render xml: @pruebas }
      end
    end
  end

  #GET /cursos/1/activas.xml
  def inactivas
    @curso = Curso.find(params[:id])
    @pruebas = @curso.pruebas
    respond_to do |format|
      if @pruebas.empty?
        format.xml { head :no_content }
      else
        @pruebas.each do |prueba|
          if prueba.estado == 'activa'
            prueba.nombre = nil
            prueba.comentario = nil
            prueba.fecha = nil
            prueba.preguntas = nil
            prueba.estado = nil
            prueba.duracion = nil
          end
        end
        format.xml { render xml: @pruebas }
      end
    end
  end

  # GET /pruebas/new
  # GET /pruebas/new.json
  def new
    @prueba = Prueba.new

    respond_to do |format|
      format.html # new.html.erb
      format.json { render json: @prueba }
    end
  end

  # GET /pruebas/1/edit
  def edit
    @prueba = Prueba.find(params[:id])
  end

  # POST /pruebas
  # POST /pruebas.json
  def create
    @prueba = Prueba.new(params[:prueba])
    @prueba.nombre = params[:nombre]
    @prueba.duracion = params[:duracion]
    @prueba.estado = params[:estado]
    @prueba.comentario = params[:comentario]
    @prueba.fecha = params[:fecha]
    @prueba.preguntas = params[:preguntas]
    @prueba.curso_id = params[:curso_id]

    respond_to do |format|
      if @prueba.save
        format.html { redirect_to @prueba, notice: 'Prueba was successfully created.' }
        format.json { render json: @prueba, status: :created, location: @prueba }
      else
        format.html { render action: "new" }
        format.json { head :no_content }
      end
    end
  end

  # PUT /pruebas/1
  # PUT /pruebas/1.json
  def update
    @prueba = Prueba.find(params[:id])
    @prueba.estado = params[:estado]
    respond_to do |format|
      if @prueba.update_attributes(params[:prueba])
        format.html { redirect_to @prueba, notice: 'Prueba was successfully updated.' }
        format.json { head :no_content }
      else
        format.html { render action: "edit" }
        format.json { render json: @prueba.errors, status: :unprocessable_entity }
      end
    end
  end

   # PUT /pruebas/1
  # PUT /pruebas/1/updatepruebas.json
  def updateinactiva

    @prueba = Prueba.find(params[:id])
    @prueba.estado = params[:estado] 
    respond_to do |format|
      
      if @prueba.update_attributes(params[:prueba])
       # format.html { render action: "edit" }
        format.json { render json: @prueba.errors }
      else
       # format.html { redirect_to @prueba, notice: 'Prueba was successfully updated.' }
        format.json { head :no_content }
      end
    end
  end

  # DELETE /pruebas/1
  # DELETE /pruebas/1.json
  def destroy
    @prueba = Prueba.find(params[:id])
    @prueba.destroy

    respond_to do |format|
      format.html { redirect_to pruebas_url }
      format.json { head :no_content }
    end
  end
end
