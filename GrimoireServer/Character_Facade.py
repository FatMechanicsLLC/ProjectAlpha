

# ---------------------------------------------------------------
# API Definitions
# facade layer
# 
# for character data retrieval or queries
# ---------------------------------------------------------------


from flask import Flask, request, jsonify
from flask_restful import Resource, Api
from json import dumps
#from flask.ext.jsonpify import jsonify

import Character_Service
from Character_Service import *

app = Flask(__name__)
CharacterApi = Api(app)

class AlignmentData(Resource):
    def get(self):
        Align = GetCharacterAlignment(self)
        return jsonify(Align)
    def put(self):
        bResult = SetCharacterAlignment(self)
        return jsonify(bResult)
    def delete(self):
        bResult = DeleteCharacterAlignment(self)
        return jsonify(bResult)

class RaceData(Resource):
    def get(self):
        Race = GetCharacterRace(self)
        return jsonify(Race)
    def put(self):
        bResult = SetCharacterRace(self)
        return jsonify(bResult)
    def delete(self):
        bResult = DeleteCharacterRace(self)
        return jsonify(bResult)

class GenderData(Resource):
    def get(self):
        Gender = GetCharacterGender(self)
        return jsonify(Gender)
    def put(self):
        bResult = SetCharacterGender(self)
        return jsonify(bResult)
    def delete(self):
        bResult = DeleteCharacterGender(self)
        return jsonify(bResult)

class ClassData(Resource):
    def get(self):
        Class = GetCharacterClass(self)
        return jsonify(Class);
    def put(self):
        bResult = SetCharacterClass(self)
        return jsonify(bResult);
    def delete(self):
        bResult = DeleteCharacterClass(self)
        return jsonify(bResult)

class PhysicalTraitsData(Resource):
    def get(self):
        PhysicalTraits = GetCharacterPhysicalTraits(self)
        return jsonify(PhysicalTraits)
    def put(self):
        bResult = SetCharacterPhysicalTraits(self)
        return jsonify(bResult)
    def delete(self):
        bResult = DeleteCharacterPhysicalTraits(self)
        return jsonify(bResult)

class AttributesData(Resource):
    def get(self):
        Attributes = GetCharacterAttributes(self)
        return jsonify(Attributes)
    def put(self):
        bResult = SetCharacterAttributes(self)
        return jsonify(bResult)
    def delete(self):
        bResult = DeleteCharacterAttributes(self)
        return jsonify(bResult)

class WealthData(Resource):
    def get(self):
        Wealth = GetCharacterWealth(self)
        return jsonify(Wealth)
    def put(self):
        bResult = SetCharacterWealth(self)
        return jsonify(bResult)
    def delete(self):
        bResult = DeleteCharacterWealth(self)
        return jsonify(bResult)

class HealthData(Resource):
    def get(self):
        Health = GetCharacterHealth(self)
        return jsonify(Health)
    def put(self):
        bResult = SetCharacterHealth(self)
        return jsonify(bResult)
    def delete(self):
        bResult = DeleteCharacterHealth(self)
        return jsonify(bResult)

class ExperienceData(Resource):
    def get(self):
        Exp = GetCharacterExperience(self)
        return jsonify(Exp)
    def put(self):
        bResult = SetCharacterExperience(self)
        return jsonify(bResult)
    def delete(self):
        bResult = DeleteCharaceterExperience(self)
        return jsonify(bResult)

class MagicAttributesData(Resource):
    def get(self):
        Magic = GetCharacterMagicAttributes(self)
        return jsonify(Magic)
    def put(self):
        bResult = SetCharacterMagicAttributes(self)
        return jsonify(bResult)
    def delete(self):
        bResult = DeleteCharacterMagicAttributes(self)
        return jsonify(bResult)

class CombatAttributesData(Resource):
    def get(self):
        Combat = GetCharacterCombatAttributes(self)
        return jsonify(Combat)
    def put(self):
        bResult = SetCharacterCombatAttributes(self)
        return jsonify(bResult)
    def delete(self):
        bResult = DeleteCharacterCombatAttributes(self)
        return jsonify(bResult)

class SocialAttributesData(Resource):
    def get(self):
        Social = GetCharacterSocialAttributes(self)
        return jsonify(Social)
    def put(self):
        bResult = SetCharacterSocialAttributes(self)
        return jsonify(bResult)
    def delete(self):
        bResult = DeleteCharacterSocialAttributes(self)
        return jsonify(bResult)



CharacterApi.add_resource(AlignmentData,'/AG/Character/Alignment')
CharacterApi.add_resource(RaceData, '/AG/Character/Race')
CharacterApi.add_resource(GenderData,'/AG/Character/Gender')
CharacterApi.add_resource(ClassData,'/AG/Character/Class')
CharacterApi.add_resource(PhysicalTraitsData,'/AG/Character/PhysicalTraits')
CharacterApi.add_resource(AttributesData,'/AG/Character/Attributes')
CharacterApi.add_resource(WealthData,'/AG/Character/Wealth')
CharacterApi.add_resource(HealthData,'/AG/Character/Health')
CharacterApi.add_resource(ExperienceData,'/AG/Character/Experience')
CharacterApi.add_resource(MagicAttributesData,'/AG/Character/MagicAttributes')
CharacterApi.add_resource(CombatAttributesData,'/AG/Character/CombatAttributes')
CharacterApi.add_resource(SocialAttributesData,'/AG/Character/SocialAttributes')


class HelloWorld(Resource):
    def get(self):
        return "My Hello World!"

CharacterApi.add_resource(HelloWorld,'/', '/Hello')

    
