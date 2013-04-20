class RespuestaController < ApplicationController
  # GET /respuesta
  # GET /respuesta.json
  def index
    @respuesta = Respuestum.all

    respond_to do |format|
      format.html # index.html.erb
      format.json { render json: @respuesta }
    end
  end

  # GET /respuesta/1
  # GET /respuesta/1.json
  def show
    @respuestum = Respuestum.find(params[:id])

    respond_to do |format|
      format.html # show.html.erb
      format.json { render json: @respuestum }
    end
  end

  # GET /respuesta/new
  # GET /respuesta/new.json
  def new
    @respuestum = Respuestum.new

    respond_to do |format|
      format.html # new.html.erb
      format.json { render json: @respuestum }
    end
  end

  # GET /respuesta/1/edit
  def edit
    @respuestum = Respuestum.find(params[:id])
  end

  # POST /respuesta
  # POST /respuesta.json
  def create
    @respuestum = Respuestum.new(params[:respuestum])

    respond_to do |format|
      if @respuestum.save
        format.html { redirect_to @respuestum, notice: 'Respuestum was successfully created.' }
        format.json { render json: @respuestum, status: :created, location: @respuestum }
      else
        format.html { render action: "new" }
        format.json { render json: @respuestum.errors, status: :unprocessable_entity }
      end
    end
  end

  # PUT /respuesta/1
  # PUT /respuesta/1.json
  def update
    @respuestum = Respuestum.find(params[:id])

    respond_to do |format|
      if @respuestum.update_attributes(params[:respuestum])
        format.html { redirect_to @respuestum, notice: 'Respuestum was successfully updated.' }
        format.json { head :no_content }
      else
        format.html { render action: "edit" }
        format.json { render json: @respuestum.errors, status: :unprocessable_entity }
      end
    end
  end

  # DELETE /respuesta/1
  # DELETE /respuesta/1.json
  def destroy
    @respuestum = Respuestum.find(params[:id])
    @respuestum.destroy

    respond_to do |format|
      format.html { redirect_to respuesta_url }
      format.json { head :no_content }
    end
  end
end
