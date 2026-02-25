using System;
using Gameplay.Aprs.View;
using Gameplay.Boss.Model;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.ToolTip.Implementations.View.Parts.Combat
{
	// Token: 0x02000152 RID: 338
	[Token(Token = "0x2000152")]
	public class MercenarieRowView : MonoBehaviour
	{
		// Token: 0x060009CB RID: 2507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x5D33", Offset = "0x5D33", VA = "0x5D33")]
		private void OnDestroy()
		{
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060009CC RID: 2508 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060009CD RID: 2509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000148")]
		public TeamData.TeamAssistantData Data
		{
			[Token(Token = "0x60009CC")]
			[Address(RVA = "0x5D34", Offset = "0x5D34", VA = "0x5D34")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009CD")]
			[Address(RVA = "0x5D35", Offset = "0x5D35", VA = "0x5D35")]
			set
			{
			}
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x1F46", Offset = "0x1F46", VA = "0x1F46")]
		private void HandleDataChanged()
		{
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x5D36", Offset = "0x5D36", VA = "0x5D36")]
		public MercenarieRowView()
		{
		}

		// Token: 0x040003ED RID: 1005
		[Token(Token = "0x40003ED")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040003EE RID: 1006
		[Token(Token = "0x40003EE")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private AprViewSmall _avatar;

		// Token: 0x040003EF RID: 1007
		[Token(Token = "0x40003EF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _skillsContainer;

		// Token: 0x040003F0 RID: 1008
		[Token(Token = "0x40003F0")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _skillRowPrefab;

		// Token: 0x040003F1 RID: 1009
		[Token(Token = "0x40003F1")]
		[FieldOffset(Offset = "0x20")]
		private TeamData.TeamAssistantData _data;
	}
}
