using System;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Il2CppDummyDll;

namespace Your.Namespace.Here.UniqueStringHereToAvoidNamespaceConflicts2.Grids
{
	// Token: 0x02000082 RID: 130
	[Token(Token = "0x2000082")]
	public class MyGridItemViewsHolder : CellViewsHolder
	{
		// Token: 0x060003AE RID: 942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x57DD", Offset = "0x57DD", VA = "0x57DD", Slot = "7")]
		public override void CollectViews()
		{
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x57DE", Offset = "0x57DE", VA = "0x57DE")]
		public MyGridItemViewsHolder()
		{
		/* --- GHIDRA: .ctor ---
		void Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts2_Grids_MyGridItemViewsHolder___ctor
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a62862 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_Core_OSA_TableParams__TupleViewsHolder__Start__);
		    DAT_ram_00a62862 = '\x01';
		  }
		  Com_TheFallenGames_OSA_Core_OSA_object__object___SmoothScrollTo
		            (param1,Method_Com_TheFallenGames_OSA_Core_OSA_TableParams__TupleViewsHolder__Start__);
		  Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts_Tables_BasicTableAdapter__LoadDataSync
		            (param1,param1);
		  return;
		}
		*/

		}
	}
}
