using System;
using Gameplay.Isles.Base.Events;
using Gameplay.Isles.Base.Model;
using Gameplay.Isles.Base.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Isles.Base.Controller
{
	// Token: 0x02000D00 RID: 3328
	[Token(Token = "0x2000D00")]
	public abstract class BaseIsleViewMediator<TController, TView, TModel, TEvents> : AbstractViewMediator<TModel, BaseIsleEvents, TController, TView> where TController : AbstractController where TView : BaseIsleView where TModel : BaseIsleModel where TEvents : BaseIsleEvents
	{
		// Token: 0x06005134 RID: 20788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005134")]
		public BaseIsleViewMediator(TModel model, TEvents events, TController controller)
		{
		}

		// Token: 0x17001074 RID: 4212
		// (set) Token: 0x06005135 RID: 20789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001074")]
		public override TView View
		{
			[Token(Token = "0x6005135")]
			set
			{
			}
		}

		// Token: 0x06005136 RID: 20790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005136")]
		private void OnClick()
		{
		}

		// Token: 0x06005137 RID: 20791
		[Token(Token = "0x6005137")]
		protected abstract void HandleClickBg();

		// Token: 0x06005138 RID: 20792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005138")]
		private void OnBuildingClickedEvent(uint type)
		{
		}

		// Token: 0x06005139 RID: 20793
		[Token(Token = "0x6005139")]
		protected abstract void HandleBuildingClick(uint type);

		// Token: 0x0600513A RID: 20794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600513A")]
		protected virtual void IsCurrentChangedEvent()
		{
		}

		// Token: 0x0600513B RID: 20795 RVA: 0x0000ED60 File Offset: 0x0000CF60
		[Token(Token = "0x600513B")]
		protected virtual bool GetBgInteractable()
		{
			return default(bool);
		}

		// Token: 0x0600513C RID: 20796
		[Token(Token = "0x600513C")]
		protected abstract void ValidateBuildingAvailability();

		// Token: 0x17001075 RID: 4213
		// (set) Token: 0x0600513D RID: 20797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001075")]
		public override BaseIsleEvents Events
		{
			[Token(Token = "0x600513D")]
			set
			{
			}
		}

		// Token: 0x0600513E RID: 20798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600513E")]
		private void IsleInformationChangedEvent()
		{
		}

		// Token: 0x0600513F RID: 20799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600513F")]
		private void BuildingStateChangedEvent(uint type)
		{
		}

		// Token: 0x06005140 RID: 20800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005140")]
		protected virtual void RenderIsle()
		{
		}

		// Token: 0x06005141 RID: 20801
		[Token(Token = "0x6005141")]
		protected abstract string GetBgAssetId();
	}
}
