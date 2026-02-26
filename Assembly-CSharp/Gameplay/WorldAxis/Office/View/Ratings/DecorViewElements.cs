using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.WorldAxis.Office.View.Ratings
{
	// Token: 0x0200030A RID: 778
	[Token(Token = "0x200030A")]
	[Serializable]
	public class DecorViewElements
	{
		// Token: 0x06001225 RID: 4645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001225")]
		[Address(RVA = "0x6420", Offset = "0x6420", VA = "0x6420")]
		public void DetermineDecorSprite(int position, bool myClan)
		{
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001226")]
		[Address(RVA = "0x6421", Offset = "0x6421", VA = "0x6421")]
		public DecorViewElements()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_WorldAxis_Office_View_Ratings_DecorViewElements___ctor
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  int *piVar3;
		  int iVar4;
		  
		  iVar4 = 0;
		  if (DAT_ram_00a58bb4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_TextMeshProUGUI___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&TMPro_TextMeshProUGUI___TypeInfo);
		    DAT_ram_00a58bb4 = '\x01';
		  }
		  uVar1 = Mono_Security_ASN1Convert__ToOid(TMPro_TextMeshProUGUI___TypeInfo,param2);
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  if (0 < param2) {
		    do {
		      uVar1 = *(undefined4 *)(param1 + 0xc);
		      param1_01 = *(undefined4 *)(param1 + 8);
		      piVar3 = *(int **)(param1 + 0x10);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      param1_00 = func_ii_6805(param1_01,uVar1,
		                               Method_UnityEngine_Object_Instantiate_TextMeshProUGUI___);
		      if ((param1_00 != 0) &&
		         (iVar2 = func_ii_1082(param1_00,*(undefined4 *)(*piVar3 + 0x20)), iVar2 == 0)) {
		        uVar1 = func_ii_1083();
		        func_ii_1050(uVar1,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      piVar3[iVar4 + 4] = param1_00;
		      iVar4 = iVar4 + 1;
		    } while (iVar4 != param2);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0400098E RID: 2446
		[Token(Token = "0x400098E")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		protected Image _decorIcon;

		// Token: 0x0400098F RID: 2447
		[Token(Token = "0x400098F")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		protected Sprite[] _placesDecors;

		// Token: 0x04000990 RID: 2448
		[Token(Token = "0x4000990")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected Sprite _defaultDecor;

		// Token: 0x04000991 RID: 2449
		[Token(Token = "0x4000991")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected Sprite _myDecor;
	}
}
