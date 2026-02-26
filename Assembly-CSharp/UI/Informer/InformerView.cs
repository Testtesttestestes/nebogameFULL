using System;
using Il2CppDummyDll;
using UI.Informer.Network;
using UnityEngine;

namespace UI.Informer
{
	// Token: 0x020001D8 RID: 472
	[Token(Token = "0x20001D8")]
	public class InformerView : MonoBehaviour
	{
		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000C54 RID: 3156 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700019A")]
		public LowNetworkResponseAbilityInformerView LowNetworkResponseAbilityInformer
		{
			[Token(Token = "0x6000C54")]
			[Address(RVA = "0x5F63", Offset = "0x5F63", VA = "0x5F63")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000C55 RID: 3157 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700019B")]
		public Transform NetworkResponseTimeExceeded
		{
			[Token(Token = "0x6000C55")]
			[Address(RVA = "0x5F64", Offset = "0x5F64", VA = "0x5F64")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C56")]
		[Address(RVA = "0x5F65", Offset = "0x5F65", VA = "0x5F65")]
		public InformerView()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Informer_InformerView___ctor(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a63914 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a63914 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x14);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = func_ii_3812(uVar2,0,0);
		  if ((param2 == 1) && (iVar1 != 0)) {
		    iVar1 = *(int *)(param1 + 0x10);
		    *(undefined4 *)(iVar1 + 0x18) = 4;
		    if (*(int *)(iVar1 + 0x14) == 0) {
		      uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (iVar1,0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar2,1,0);
		      UI_Informer_Network_LowNetworkResponseAbilityInformerView__SetStatus(param1,1,param1);
		      return;
		    }
		  }
		  else if (param2 == 2) {
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x10),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,0,0);
		  }
		  UI_Informer_Network_LowNetworkResponseAbilityInformerView__SetStatus(param1,param2,param1);
		  return;
		}
		*/

		}

		// Token: 0x040005F0 RID: 1520
		[Token(Token = "0x40005F0")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private LowNetworkResponseAbilityInformerView lowNetworkResponseAbilityInformer;

		// Token: 0x040005F1 RID: 1521
		[Token(Token = "0x40005F1")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _networkResponseTimeExceeded;
	}
}
