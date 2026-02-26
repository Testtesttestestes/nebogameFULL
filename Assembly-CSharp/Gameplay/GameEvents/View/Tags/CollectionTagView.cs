using System;
using Gameplay.Collections.View;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.GameEvents.View.Tags
{
	// Token: 0x02000785 RID: 1925
	[Token(Token = "0x2000785")]
	public class CollectionTagView : MonoBehaviour
	{
		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x06002DCB RID: 11723 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170008CE")]
		public CollectionIconView CollectionIconView
		{
			[Token(Token = "0x6002DCB")]
			[Address(RVA = "0x7E49", Offset = "0x7E49", VA = "0x7E49")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002DCC RID: 11724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DCC")]
		[Address(RVA = "0x7E4A", Offset = "0x7E4A", VA = "0x7E4A")]
		public CollectionTagView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_GameEvents_View_Tags_CollectionTagView___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a574a2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_GameRawImage___);
		    DAT_ram_00a574a2 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  if (param1_00 == 0) {
		    param1_00 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_GameRawImage___);
		  }
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(param1_00,param2,0);
		  return;
		}
		*/

		}

		// Token: 0x04001920 RID: 6432
		[Token(Token = "0x4001920")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private CollectionIconView _collectionIconView;
	}
}
