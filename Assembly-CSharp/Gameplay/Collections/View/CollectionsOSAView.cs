using System;
using Il2CppDummyDll;
using UI;
using UnityEngine.UI;

namespace Gameplay.Collections.View
{
	// Token: 0x020009CA RID: 2506
	[Token(Token = "0x20009CA")]
	public class CollectionsOSAView : OSAGenericBase<CollectionsViewsHolder, CollectionListElement.CollectionListElementArgs>
	{
		// Token: 0x06003C0A RID: 15370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C0A")]
		[Address(RVA = "0x8AD9", Offset = "0x8AD9", VA = "0x8AD9", Slot = "69")]
		protected override void Start()
		{
		/* --- GHIDRA: Start ---
		undefined4
		Gameplay_Collections_View_CollectionsOSAView__Start(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57e92 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Collections_View_CollectionsViewsHolder_TypeInfo);
		    DAT_ram_00a57e92 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Gameplay_Collections_View_CollectionsViewsHolder_TypeInfo);
		  if (DAT_ram_00a57e97 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ItemViewsHolder_CollectionListElement___ctor__);
		    DAT_ram_00a57e97 = '\x01';
		  }
		  Com_TheFallenGames_OSA_Core_AbstractViewsHolder__set_ItemIndex
		            (param1_00,*(undefined4 *)(*(int *)(param1 + 0x10) + 0x4c),
		             *(undefined4 *)(*(int *)(param1 + 0x10) + 8),param2,1,1,0);
		  return param1_00;
		}
		*/

		}

		// Token: 0x06003C0B RID: 15371 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003C0B")]
		[Address(RVA = "0x8ADA", Offset = "0x8ADA", VA = "0x8ADA", Slot = "99")]
		protected override CollectionsViewsHolder CreateViewsHolder(int itemIndex)
		{
		/* --- GHIDRA: CreateViewsHolder ---
		void Gameplay_Collections_View_CollectionsOSAView__CreateViewsHolder
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57e95 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_OSAGenericBase_CollectionsViewsHolder__CollectionListElement_CollectionListElementArgs___ctor__
		              );
		    DAT_ram_00a57e95 = '\x01';
		  }
		  UI_OSADynamicBase_object__object___get_MinElementsToUpdate
		            (param1,
		             Method_UI_OSAGenericBase_CollectionsViewsHolder__CollectionListElement_CollectionListElementArgs___ctor__
		            );
		  return;
		}
		*/

		/* --- GHIDRA: CreateViewsHolder ---
		void Gameplay_Collections_View_CollectionsOSAView__CreateViewsHolder
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57e95 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_OSAGenericBase_CollectionsViewsHolder__CollectionListElement_CollectionListElementArgs___ctor__
		              );
		    DAT_ram_00a57e95 = '\x01';
		  }
		  UI_OSADynamicBase_object__object___get_MinElementsToUpdate
		            (param1,
		             Method_UI_OSAGenericBase_CollectionsViewsHolder__CollectionListElement_CollectionListElementArgs___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06003C0C RID: 15372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C0C")]
		[Address(RVA = "0x8ADB", Offset = "0x8ADB", VA = "0x8ADB", Slot = "100")]
		protected override void UpdateViewsHolder(CollectionsViewsHolder newOrRecycled)
		{
		/* --- GHIDRA: UpdateViewsHolder ---
		undefined4
		Gameplay_Collections_View_CollectionsOSAView__UpdateViewsHolder(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57e94 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Collections_View_CollectionsViewsHolder_TypeInfo);
		    DAT_ram_00a57e94 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Collections_View_CollectionsViewsHolder_TypeInfo);
		  if (DAT_ram_00a57e97 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ItemViewsHolder_CollectionListElement___ctor__);
		    DAT_ram_00a57e97 = '\x01';
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x06003C0D RID: 15373 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003C0D")]
		[Address(RVA = "0x8ADC", Offset = "0x8ADC", VA = "0x8ADC", Slot = "119")]
		protected override CollectionsViewsHolder CreateViewsHolder()
		{
			return null;
		}

		// Token: 0x06003C0E RID: 15374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C0E")]
		[Address(RVA = "0x8ADD", Offset = "0x8ADD", VA = "0x8ADD")]
		public CollectionsOSAView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Collections_View_CollectionsOSAView___ctor(int param1,int *param2,undefined4 param3)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a57e96 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Collections_View_CollectionListElement_CollectionListElementArgs_TypeInfo);
		    DAT_ram_00a57e96 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  if (param2 != (int *)0x0) {
		    if (((uint)*(byte *)(*param2 + 0xb8) <
		         (uint)*(byte *)(
		                        Gameplay_Collections_View_CollectionListElement_CollectionListElementArgs_TypeInfo
		                        + 0xb8)) ||
		       (*(int *)(*(int *)(*param2 + 100) +
		                 (uint)*(byte *)(
		                                Gameplay_Collections_View_CollectionListElement_CollectionListElementArgs_TypeInfo
		                                + 0xb8) * 4 + -4) !=
		        Gameplay_Collections_View_CollectionListElement_CollectionListElementArgs_TypeInfo)) {
		      System_Activator__CreateInstance
		                (param2,
		                 Gameplay_Collections_View_CollectionListElement_CollectionListElementArgs_TypeInfo)
		      ;
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  if (DAT_ram_00a57e75 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_CollectionListElement_CollectionListElementArgs__Init__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_CollectionListElement_CollectionListElementArgs__get_Initted__
		              );
		    DAT_ram_00a57e75 = '\x01';
		  }
		  if (*(char *)(param1_00 + 0x1c) == '\0') {
		    UI_Elements_Buildings_SpellItemArgs___ctor
		              (param1_00,param2,
		               Method_UI_Elements_GenericList_GenericListElement_CollectionListElement_CollectionListElementArgs__Init__
		              );
		    return;
		  }
		  Gameplay_Collections_View_CollectionListElement__get_GuideTarget(param1_00,param2,param2);
		  Gameplay_Collections_View_CollectionListElement__OnInit(param1_00,param2);
		  return;
		}
		*/

		}

		// Token: 0x04002123 RID: 8483
		[Token(Token = "0x4002123")]
		[FieldOffset(Offset = "0xA4")]
		private Mask _viewportMask;
	}
}
