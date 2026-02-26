using System;
using AssetContent;
using Il2CppDummyDll;
using UI.Elements.GenericList;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.RegisterV2.View.CultSelector
{
	// Token: 0x02000566 RID: 1382
	[Token(Token = "0x2000566")]
	public class CultListElement : SelectedGenericListElement<CultListElementArgs>
	{
		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06002150 RID: 8528 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000619")]
		public GameRawImage CultImage
		{
			[Token(Token = "0x6002150")]
			[Address(RVA = "0x72B2", Offset = "0x72B2", VA = "0x72B2")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06002151 RID: 8529 RVA: 0x00006A80 File Offset: 0x00004C80
		// (set) Token: 0x06002152 RID: 8530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700061A")]
		public override bool Selected
		{
			[Token(Token = "0x6002151")]
			[Address(RVA = "0x72B3", Offset = "0x72B3", VA = "0x72B3", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002152")]
			[Address(RVA = "0x72B4", Offset = "0x72B4", VA = "0x72B4", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x06002153 RID: 8531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002153")]
		[Address(RVA = "0x72B5", Offset = "0x72B5", VA = "0x72B5", Slot = "4")]
		protected override void OnInit(CultListElementArgs args)
		{
		/* --- GHIDRA: OnInit ---
		void Gameplay_RegisterV2_View_CultSelector_CultListElement__OnInit
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5837f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectedGenericListElement_CultListElementArgs___ctor__
		              );
		    DAT_ram_00a5837f = '\x01';
		  }
		  UI_Elements_GenericList_SelectedGenericListArgs_object____ctor
		            (param1,
		             Method_UI_Elements_GenericList_SelectedGenericListElement_CultListElementArgs___ctor__)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x06002154 RID: 8532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002154")]
		[Address(RVA = "0x72B6", Offset = "0x72B6", VA = "0x72B6")]
		public CultListElement()
		{
		}

		// Token: 0x04001233 RID: 4659
		[Token(Token = "0x4001233")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameRawImage _cultImage;

		// Token: 0x04001234 RID: 4660
		[Token(Token = "0x4001234")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Image _selectedImage;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_CultImage ---
		uint Gameplay_RegisterV2_View_CultSelector_CultListElement__get_CultImage
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5837d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectedGenericListElement_CultListElementArgs__get_Selected__
		              );
		    DAT_ram_00a5837d = '\x01';
		  }
		  return (uint)*(byte *)(param1 + 0x1d);
		}
		*/


		/* --- GHIDRA: get_Selected ---
		void Gameplay_RegisterV2_View_CultSelector_CultListElement__get_Selected
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5837e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectedGenericListElement_CultListElementArgs__set_Selected__
		              );
		    DAT_ram_00a5837e = '\x01';
		  }
		  *(char *)(param1 + 0x1d) = (char)param2;
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x24),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,param2,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_Selected ---
		void Gameplay_RegisterV2_View_CultSelector_CultListElement__set_Selected
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  param1_00 = *(undefined4 *)(param1 + 0x20);
		  param2_00 = Core_Extensions_Dict_CultDicExt__GetIcon128AssetId(*(undefined4 *)(param2 + 0xc),0);
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(param1_00,param2_00,0);
		  return;
		}
		*/

}
