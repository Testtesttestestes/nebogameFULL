using System;
using Il2CppDummyDll;

namespace Gameplay.Tutorial.Guide.View.Outline
{
	// Token: 0x0200046B RID: 1131
	[Token(Token = "0x200046B")]
	public class GuideOutlinePulse : AbstractGuideOutline
	{
		// Token: 0x06001ADA RID: 6874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ADA")]
		[Address(RVA = "0x6C64", Offset = "0x6C64", VA = "0x6C64", Slot = "5")]
		public override void StartAnimation(float delay)
		{
		}

		// Token: 0x06001ADB RID: 6875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ADB")]
		[Address(RVA = "0x6C65", Offset = "0x6C65", VA = "0x6C65", Slot = "6")]
		public override void StopAnimation()
		{
		/* --- GHIDRA: StopAnimation ---
		void Gameplay_Tutorial_Guide_View_Outline_GuideOutlinePulse__StopAnimation
		               (undefined4 param1,float param2,float param3,undefined4 param4)
		
		{
		  int *param1_00;
		  undefined8 local_10;
		  float4 local_8;
		  float4 local_4;
		  
		  if (DAT_ram_00a58462 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_RectTransform_TypeInfo);
		    DAT_ram_00a58462 = '\x01';
		  }
		  param1_00 = (int *)System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                               (param1,0);
		  if ((param1_00 != (int *)0x0) && (UnityEngine_RectTransform_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,UnityEngine_RectTransform_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  local_10 = CONCAT44(param3,param2);
		  local_8 = (float4)param2;
		  local_4 = (float4)param3;
		  UnityEngine_RectTransform__get_sizeDelta(param1_00,&local_10,0);
		  return;
		}
		*/

		}

		// Token: 0x06001ADC RID: 6876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ADC")]
		[Address(RVA = "0x6C66", Offset = "0x6C66", VA = "0x6C66", Slot = "4")]
		protected override void HandleSizeChanged(float width, float height)
		{
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ADD")]
		[Address(RVA = "0x6C67", Offset = "0x6C67", VA = "0x6C67")]
		public GuideOutlinePulse()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Tutorial_Guide_View_Outline_GuideOutlinePulse___ctor
		               (int param1,float param2,float param3,undefined4 param4)
		
		{
		  float fVar1;
		  float fVar2;
		  undefined8 local_1e0;
		  undefined8 local_1d8;
		  undefined8 local_1d0;
		  ulonglong local_1c8;
		  undefined4 local_1c0;
		  undefined8 local_1b8;
		  undefined4 local_1b0;
		  undefined8 local_1a8;
		  undefined8 local_1a0;
		  undefined8 local_198;
		  ulonglong local_190;
		  undefined4 local_188;
		  undefined8 local_180;
		  undefined4 local_178;
		  undefined8 local_170;
		  undefined8 local_168;
		  undefined8 local_160;
		  longlong local_158;
		  undefined4 local_150;
		  undefined8 local_148;
		  undefined4 local_140;
		  undefined8 local_138;
		  undefined8 local_130;
		  undefined8 local_128;
		  longlong local_120;
		  undefined4 local_118;
		  undefined8 local_110;
		  undefined4 local_108;
		  undefined8 local_100;
		  undefined4 local_f8;
		  undefined8 local_f0;
		  undefined8 local_e8;
		  undefined8 local_e0;
		  float4 local_d8;
		  undefined4 local_d4;
		  undefined4 uStack_d0;
		  float4 local_cc;
		  float4 local_c8;
		  undefined4 local_c4;
		  undefined8 local_c0;
		  undefined8 local_b8;
		  undefined8 local_b0;
		  float4 local_a8;
		  undefined4 local_a4;
		  undefined4 uStack_a0;
		  float4 local_9c;
		  float4 local_98;
		  undefined4 local_94;
		  undefined8 local_90;
		  undefined8 local_88;
		  undefined8 local_80;
		  undefined4 local_78;
		  float4 local_74;
		  undefined4 local_70;
		  float4 local_6c;
		  float4 local_68;
		  undefined4 local_64;
		  undefined8 local_60;
		  undefined8 local_58;
		  undefined8 local_50;
		  undefined4 local_48;
		  float4 local_44;
		  undefined4 local_40;
		  float4 local_3c;
		  float4 local_38;
		  undefined4 local_34;
		  float4 local_30;
		  float4 local_2c;
		  undefined4 local_28;
		  undefined4 local_24;
		  undefined4 local_20;
		  undefined4 local_1c;
		  undefined4 local_18;
		  undefined4 local_14;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  local_4 = *(undefined4 *)(param1 + 0x14);
		  local_28 = 0;
		  local_f8 = 0;
		  local_100 = CONCAT44(param3,param2);
		  local_30 = (float4)param2;
		  local_2c = (float4)param3;
		  UnityEngine_ParticleSystem_ShapeModule__set_position_Injected(&local_4,&local_100,0);
		  local_8 = *(undefined4 *)(param1 + 0x18);
		  local_34 = 0;
		  local_108 = 0;
		  fVar1 = param3 * 0.5;
		  fVar2 = param2 * 0.5;
		  local_110 = CONCAT44(fVar1,fVar2);
		  local_3c = (float4)fVar2;
		  local_38 = (float4)fVar1;
		  UnityEngine_ParticleSystem_ShapeModule__set_position_Injected(&local_8,&local_110,0);
		  local_40 = 0;
		  local_118 = 0;
		  local_48 = 0;
		  local_120 = (ulonglong)(uint)fVar1 << 0x20;
		  local_44 = (float4)fVar1;
		  UnityEngine_ParticleSystem_ShapeModule__set_scale(&local_8,&local_120,0);
		  local_c = *(undefined4 *)(param1 + 0x18);
		  UnityEngine_ParticleSystem_MinMaxCurve__get_curve(&local_60,*(float *)(param1 + 0x28) * param2,0);
		  local_128 = local_50;
		  local_130 = local_58;
		  local_138 = local_60;
		  UnityEngine_ParticleSystem_EmissionModule__set_enabled(&local_c,&local_138,0);
		  local_10 = *(undefined4 *)(param1 + 0x20);
		  local_64 = 0;
		  local_140 = 0;
		  local_148 = CONCAT44(fVar1,fVar2);
		  local_6c = (float4)fVar2;
		  local_68 = (float4)fVar1;
		  UnityEngine_ParticleSystem_ShapeModule__set_position_Injected(&local_10,&local_148,0);
		  local_70 = 0;
		  local_150 = 0;
		  local_74 = (float4)(param3 * -0.5);
		  local_78 = 0;
		  local_158 = (ulonglong)(uint)local_74 << 0x20;
		  UnityEngine_ParticleSystem_ShapeModule__set_scale(&local_10,&local_158,0);
		  local_14 = *(undefined4 *)(param1 + 0x20);
		  UnityEngine_ParticleSystem_MinMaxCurve__get_curve(&local_90,*(float *)(param1 + 0x28) * param2,0);
		  local_160 = local_80;
		  local_168 = local_88;
		  local_170 = local_90;
		  UnityEngine_ParticleSystem_EmissionModule__set_enabled(&local_14,&local_170,0);
		  local_18 = *(undefined4 *)(param1 + 0x1c);
		  local_94 = 0;
		  local_178 = 0;
		  local_180 = CONCAT44(fVar2,fVar1);
		  local_9c = (float4)fVar1;
		  local_98 = (float4)fVar2;
		  UnityEngine_ParticleSystem_ShapeModule__set_position_Injected(&local_18,&local_180,0);
		  local_a4 = 0;
		  uStack_a0 = 0;
		  local_188 = 0;
		  local_a8 = (float4)(param2 * -0.5);
		  local_190 = (ulonglong)(uint)local_a8;
		  UnityEngine_ParticleSystem_ShapeModule__set_scale(&local_18,&local_190,0);
		  local_1c = *(undefined4 *)(param1 + 0x1c);
		  UnityEngine_ParticleSystem_MinMaxCurve__get_curve(&local_c0,*(float *)(param1 + 0x28) * param3,0);
		  local_198 = local_b0;
		  local_1a0 = local_b8;
		  local_1a8 = local_c0;
		  UnityEngine_ParticleSystem_EmissionModule__set_enabled(&local_1c,&local_1a8,0);
		  local_20 = *(undefined4 *)(param1 + 0x24);
		  local_c4 = 0;
		  local_1b0 = 0;
		  local_1b8 = CONCAT44(fVar2,fVar1);
		  local_cc = (float4)fVar1;
		  local_c8 = (float4)fVar2;
		  UnityEngine_ParticleSystem_ShapeModule__set_position_Injected(&local_20,&local_1b8,0);
		  local_d4 = 0;
		  uStack_d0 = 0;
		  local_1c0 = 0;
		  local_1c8 = (ulonglong)(uint)fVar2;
		  local_d8 = (float4)fVar2;
		  UnityEngine_ParticleSystem_ShapeModule__set_scale(&local_20,&local_1c8,0);
		  local_24 = *(undefined4 *)(param1 + 0x24);
		  UnityEngine_ParticleSystem_MinMaxCurve__get_curve(&local_f0,*(float *)(param1 + 0x28) * param3,0);
		  local_1d0 = local_e0;
		  local_1d8 = local_e8;
		  local_1e0 = local_f0;
		  UnityEngine_ParticleSystem_EmissionModule__set_enabled(&local_24,&local_1e0,0);
		  return;
		}
		*/

		}
	}
}
