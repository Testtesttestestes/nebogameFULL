using System;
using CloudsFly;
using Gameplay.Boss.Model;
using Il2CppDummyDll;
using UI;
using UnityEngine;

namespace Gameplay.Boss.View.WorldView
{
	// Token: 0x02000B52 RID: 2898
	[Token(Token = "0x2000B52")]
	public class IsleBossCreateRequestView : BaseWorldObjectRenderer
	{
		// Token: 0x0600461E RID: 17950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600461E")]
		[Address(RVA = "0x94B7", Offset = "0x94B7", VA = "0x94B7")]
		public void Init(BossCreateRequestData data)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Boss_View_WorldView_IsleBossCreateRequestView__Init(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a579b1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_Renderer___);
		    DAT_ram_00a579b1 = '\x01';
		  }
		  param1_00 = func_ii_5677(*(undefined4 *)(param1 + 0x24),
		                           Method_UnityEngine_Component_GetComponent_Renderer___);
		  AssetContent_Loaders_GameSpriteRendererLoader__get_SpriteRenderer
		            (param1_00,*(undefined4 *)(param1 + 0x14),0);
		  return;
		}
		*/

		}

		// Token: 0x0600461F RID: 17951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600461F")]
		[Address(RVA = "0x94B8", Offset = "0x94B8", VA = "0x94B8", Slot = "8")]
		protected override void ApplySortingOrder()
		{
		/* --- GHIDRA: ApplySortingOrder ---
		void Gameplay_Boss_View_WorldView_IsleBossCreateRequestView__ApplySortingOrder
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a579b2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_Renderer___);
		    DAT_ram_00a579b2 = '\x01';
		  }
		  param1_00 = func_ii_5677(*(undefined4 *)(param1 + 0x24),
		                           Method_UnityEngine_Component_GetComponent_Renderer___);
		  func_ii_7677(param1_00,*(undefined4 *)(param1 + 0x18),0);
		  return;
		}
		*/

		}

		// Token: 0x06004620 RID: 17952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004620")]
		[Address(RVA = "0x94B9", Offset = "0x94B9", VA = "0x94B9", Slot = "9")]
		protected override void ApplySortingLayerId()
		{
		}

		// Token: 0x06004621 RID: 17953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004621")]
		[Address(RVA = "0x94BA", Offset = "0x94BA", VA = "0x94BA")]
		public IsleBossCreateRequestView()
		{
		}

		// Token: 0x0400265D RID: 9821
		[Token(Token = "0x400265D")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private BacktimeView _backtimeView;
	}
}
