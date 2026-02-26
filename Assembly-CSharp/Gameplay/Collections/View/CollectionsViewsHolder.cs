using System;
using Il2CppDummyDll;
using UI;
using UI.Elements.GenericList;

namespace Gameplay.Collections.View
{
	// Token: 0x020009CB RID: 2507
	[Token(Token = "0x20009CB")]
	public class CollectionsViewsHolder : ItemViewsHolder<CollectionListElement>
	{
		// Token: 0x06003C0F RID: 15375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C0F")]
		[Address(RVA = "0x8ADE", Offset = "0x8ADE", VA = "0x8ADE", Slot = "13")]
		public override void SetData(GenericListElementArgs args)
		{
		/* --- GHIDRA: SetData ---
		void Gameplay_Collections_View_CollectionsViewsHolder__SetData(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57e97 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ItemViewsHolder_CollectionListElement___ctor__);
		    DAT_ram_00a57e97 = '\x01';
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003C10 RID: 15376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C10")]
		[Address(RVA = "0x8ADF", Offset = "0x8ADF", VA = "0x8ADF")]
		public CollectionsViewsHolder()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Collections_View_CollectionsViewsHolder___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57e98 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12600);
		    DAT_ram_00a57e98 = '\x01';
		  }
		  return StringLiteral_12600;
		}
		*/

		}
	}
}
