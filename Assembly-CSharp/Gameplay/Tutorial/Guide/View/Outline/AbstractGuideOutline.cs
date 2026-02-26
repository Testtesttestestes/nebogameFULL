using System;
using System.Runtime.CompilerServices;
using Gameplay.Tutorial.Guide.Model.Shapes;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Tutorial.Guide.View.Outline
{
	// Token: 0x02000469 RID: 1129
	[Token(Token = "0x2000469")]
	public abstract class AbstractGuideOutline : MonoBehaviour
	{
		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06001ACC RID: 6860 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001ACD RID: 6861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004AD")]
		public AbstractShape Shape
		{
			[Token(Token = "0x6001ACC")]
			[Address(RVA = "0x6C59", Offset = "0x6C59", VA = "0x6C59")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001ACD")]
			[Address(RVA = "0x6C5A", Offset = "0x6C5A", VA = "0x6C5A")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001ACE RID: 6862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ACE")]
		[Address(RVA = "0x6C5B", Offset = "0x6C5B", VA = "0x6C5B")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Tutorial_Guide_View_Outline_AbstractGuideOutline__Awake
		               (int *param1,float param2,float param3,undefined4 param4)
		
		{
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		            (param1,param2,param3,*(undefined4 *)(*param1 + 0xe4));
		  return;
		}
		*/

		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ACF")]
		[Address(RVA = "0x6C5C", Offset = "0x6C5C", VA = "0x6C5C")]
		public void SetSize(float width, float height)
		{
		}

		// Token: 0x06001AD0 RID: 6864
		[Token(Token = "0x6001AD0")]
		protected abstract void HandleSizeChanged(float width, float height);

		// Token: 0x06001AD1 RID: 6865
		[Token(Token = "0x6001AD1")]
		public abstract void StartAnimation(float delay);

		// Token: 0x06001AD2 RID: 6866
		[Token(Token = "0x6001AD2")]
		public abstract void StopAnimation();

		// Token: 0x06001AD3 RID: 6867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AD3")]
		[Address(RVA = "0x6C5D", Offset = "0x6C5D", VA = "0x6C5D")]
		protected AbstractGuideOutline()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Tutorial_Guide_View_Outline_AbstractGuideOutline___ctor
		               (int param1,float param2,float param3,undefined4 param4)
		
		{
		  float fVar1;
		  float fVar2;
		  undefined8 local_70;
		  undefined4 local_68;
		  undefined8 local_60;
		  undefined8 local_58;
		  undefined8 local_50;
		  undefined8 local_48;
		  undefined4 local_40;
		  float4 local_3c;
		  float4 local_38;
		  undefined4 local_34;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  float4 local_18;
		  float4 local_14;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  local_4 = *(undefined4 *)(param1 + 0x14);
		  local_10 = 0;
		  local_40 = 0;
		  fVar1 = param3 * 0.5;
		  fVar2 = param2 * 0.5;
		  local_48 = CONCAT44(fVar1,fVar2);
		  local_18 = (float4)fVar2;
		  local_14 = (float4)fVar1;
		  UnityEngine_ParticleSystem_ShapeModule__set_position_Injected(&local_4,&local_48,0);
		  local_8 = *(undefined4 *)(param1 + 0x18);
		  UnityEngine_ParticleSystem_MinMaxCurve__get_curve
		            (&local_30,(param2 + param3) * 3.1415927 * *(float *)(param1 + 0x1c),0);
		  local_50 = local_20;
		  local_58 = local_28;
		  local_60 = local_30;
		  UnityEngine_ParticleSystem_EmissionModule__set_enabled(&local_8,&local_60,0);
		  local_c = *(undefined4 *)(param1 + 0x18);
		  local_34 = 0;
		  local_68 = 0;
		  local_70 = CONCAT44(fVar1,fVar2);
		  local_3c = (float4)fVar2;
		  local_38 = (float4)fVar1;
		  UnityEngine_ParticleSystem_ShapeModule__set_position_Injected(&local_c,&local_70,0);
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Shape ---
		void Gameplay_Tutorial_Guide_View_Outline_AbstractGuideOutline__set_Shape
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  float4 local_8;
		  float4 local_4;
		  
		  if (DAT_ram_00a58460 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_RectTransform___);
		    DAT_ram_00a58460 = '\x01';
		  }
		  param2_00 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_RectTransform___);
		  UnityEngine_RectTransform__set_anchoredPosition(&local_8,param2_00,0);
		  UnityEngine_RectTransform__set_anchoredPosition(&local_8,param2_00,0);
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		            (param1,local_8,local_4,*(undefined4 *)(*param1 + 0xe4));
		  return;
		}
		*/

}
