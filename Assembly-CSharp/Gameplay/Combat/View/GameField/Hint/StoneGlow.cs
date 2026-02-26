using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Combat;
using UnityEngine;
using Utils.Cache;

namespace Gameplay.Combat.View.GameField.Hint
{
	// Token: 0x02000978 RID: 2424
	[Token(Token = "0x2000978")]
	public class StoneGlow : MonoBehaviour, IPoolElement<StoneGlow>
	{
		// Token: 0x060039BD RID: 14781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039BD")]
		[Address(RVA = "0x894D", Offset = "0x894D", VA = "0x894D")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		float Gameplay_Combat_View_GameField_Hint_StoneGlow__Start
		                (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  float fVar2;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57df5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_StoneGlowElement___);
		    Mono_Security_ASN1__get_Item(&System_Func_StoneGlowElement__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_GameField_Hint_StoneGlow___c__DisplayClass4_0__Glow_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Combat_View_GameField_Hint_StoneGlow___c__DisplayClass4_0_TypeInfo);
		    DAT_ram_00a57df5 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Combat_View_GameField_Hint_StoneGlow___c__DisplayClass4_0_TypeInfo);
		  *(undefined4 *)(iVar1 + 0xc) = param3;
		  *(undefined4 *)(iVar1 + 8) = param2;
		  param1_01 = *(undefined4 *)(param1 + 0x14);
		  param1_00 = unnamed_function_1417(System_Func_StoneGlowElement__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (param1_00,iVar1,
		             Method_Gameplay_Combat_View_GameField_Hint_StoneGlow___c__DisplayClass4_0__Glow_b__0__,
		             0);
		  iVar1 = System_Func_object__bool____ctor
		                    (param1_01,param1_00,
		                     Method_System_Linq_Enumerable_FirstOrDefault_StoneGlowElement___);
		  if (iVar1 == 0) {
		    return *(float *)(param1 + 0x10);
		  }
		  Core_Animations_GameSpineAnimation__Stop(*(undefined4 *)(*(int *)(iVar1 + 0x10) + 0x14),1,0);
		  Core_Animations_GameSpineAnimation__Init(*(undefined4 *)(iVar1 + 0x10),0,0);
		  fVar2 = Core_Animations_GameSpineAnimation__Play(*(undefined4 *)(iVar1 + 0x10),0);
		  return fVar2;
		}
		*/

		}

		// Token: 0x060039BE RID: 14782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039BE")]
		[Address(RVA = "0x19E0", Offset = "0x19E0", VA = "0x19E0")]
		public void StopGlow()
		{
		/* --- GHIDRA: StopGlow ---
		void Gameplay_Combat_View_GameField_Hint_StoneGlow__StopGlow(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57df6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cache_ObjectPool_StoneGlow__Release__);
		    DAT_ram_00a57df6 = '\x01';
		  }
		  func_ii_7070(*(undefined4 *)(param1 + 0x18),param1,
		               Method_Utils_Cache_ObjectPool_StoneGlow__Release__);
		  return;
		}
		*/

		}

		// Token: 0x060039BF RID: 14783 RVA: 0x0000B868 File Offset: 0x00009A68
		[Token(Token = "0x60039BF")]
		[Address(RVA = "0x894E", Offset = "0x894E", VA = "0x894E")]
		public float Glow(StonesTypes stoneType, uint setID)
		{
			return 0f;
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x060039C0 RID: 14784 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060039C1 RID: 14785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B53")]
		public ObjectPool<StoneGlow> Pool
		{
			[Token(Token = "0x60039C0")]
			[Address(RVA = "0x894F", Offset = "0x894F", VA = "0x894F", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60039C1")]
			[Address(RVA = "0x8950", Offset = "0x8950", VA = "0x8950", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060039C2 RID: 14786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039C2")]
		[Address(RVA = "0x19E1", Offset = "0x19E1", VA = "0x19E1", Slot = "6")]
		public void Release()
		{
		/* --- GHIDRA: Release ---
		int * Gameplay_Combat_View_GameField_Hint_StoneGlow__Release(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060039C3 RID: 14787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039C3")]
		[Address(RVA = "0x8951", Offset = "0x8951", VA = "0x8951")]
		public StoneGlow()
		{
		}

		// Token: 0x04001FF3 RID: 8179
		[Token(Token = "0x4001FF3")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float _defaultDuration;

		// Token: 0x04001FF4 RID: 8180
		[Token(Token = "0x4001FF4")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private List<StoneGlowElement> _glowElements;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Pool ---
		void Gameplay_Combat_View_GameField_Hint_StoneGlow__set_Pool(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x10) = 0x3f800000;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

}
