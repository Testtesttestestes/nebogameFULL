using System;
using Gameplay.Isles.Axis.View;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly
{
	// Token: 0x020012E9 RID: 4841
	[Token(Token = "0x20012E9")]
	public class AxisIsleWorldObject : BaseIsleWorldObject
	{
		// Token: 0x06007345 RID: 29509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007345")]
		[Address(RVA = "0xBD4E", Offset = "0xBD4E", VA = "0xBD4E", Slot = "12")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x06007346 RID: 29510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007346")]
		[Address(RVA = "0xBD4F", Offset = "0xBD4F", VA = "0xBD4F", Slot = "13")]
		public override void UpdateOrder()
		{
		/* --- GHIDRA: UpdateOrder ---
		void CloudsFly_AxisIsleWorldObject__UpdateOrder(int param1,undefined4 param2)
		
		{
		  *(undefined8 *)(param1 + 0x38) = 0;
		  Gameplay_Isles_Base_View_IsleBossContainer__ValidateBoss(*(undefined4 *)(param1 + 0x30),0);
		  *(undefined4 *)(param1 + 0x40) = 0;
		  Gameplay_Ad_BattleFinishAd_View_BattleFinishAdView__Init(*(undefined4 *)(param1 + 0x44),0);
		  return;
		}
		*/

		}

		// Token: 0x06007347 RID: 29511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007347")]
		[Address(RVA = "0xBD50", Offset = "0xBD50", VA = "0xBD50", Slot = "14")]
		public override void Reset()
		{
		}

		// Token: 0x06007348 RID: 29512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007348")]
		[Address(RVA = "0xBD51", Offset = "0xBD51", VA = "0xBD51")]
		public AxisIsleWorldObject()
		{
		/* --- GHIDRA: .ctor ---
		void CloudsFly_AxisIsleWorldObject___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5966c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_CloudsFly_BaseIsleWorldObjectEngine_AxisIsleWorldObjectEngineArgs___ctor__);
		    DAT_ram_00a5966c = '\x01';
		  }
		  Gameplay_Isles_Base_Controller_BaseIsleViewMediator_object__object__object__object___set_View
		            (param1,
		             Method_CloudsFly_BaseIsleWorldObjectEngine_AxisIsleWorldObjectEngineArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x04003C58 RID: 15448
		[Token(Token = "0x4003C58")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private AxisIsleView _axisIsleView;
	}
}
